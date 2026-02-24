using System.Globalization;
using System.Net;
using ApiCm.Services.Interfaces;
using MaxMind.GeoIP2;
using Microsoft.Extensions.Caching.Memory;

namespace ApiCm.Services;

public class GeolocationService : IGeolocationService, IDisposable
{
    private readonly ILogger<GeolocationService> _logger;
    private readonly IMemoryCache _cache;
    private readonly IConfiguration _configuration;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly DatabaseReader? _mmdbReader;

    public GeolocationService(
        ILogger<GeolocationService> logger,
        IMemoryCache cache,
        IConfiguration configuration,
        IHttpContextAccessor httpContextAccessor
    )
    {
        _logger = logger;
        _cache = cache;
        _configuration = configuration;
        _httpContextAccessor = httpContextAccessor;
        _mmdbReader = InitializeMaxMindDatabase();

        _logger.LogInformation(
            "GeolocationService initialized. Cloudflare-first approach. MaxMind fallback: {MaxMindAvailable}",
            _mmdbReader != null
        );
    }

    private DatabaseReader? InitializeMaxMindDatabase()
    {
        var mmdbPath = _configuration["GeoIP:MmdbPath"];
        if (string.IsNullOrWhiteSpace(mmdbPath) || !File.Exists(mmdbPath))
            return null;

        try
        {
            return new DatabaseReader(mmdbPath);
        }
        catch (Exception ex)
        {
            _logger.LogWarning(
                ex,
                "MaxMind database could not be loaded, using Cloudflare-only approach"
            );
            return null;
        }
    }

    public Task<GeolocationInfo?> GetLocationInfoAsync(string ipAddress)
    {
        if (string.IsNullOrWhiteSpace(ipAddress))
            return Task.FromResult<GeolocationInfo?>(null);

        if (IsLocalIpAddress(ipAddress))
            return Task.FromResult<GeolocationInfo?>(CreateLocalGeolocationInfo(ipAddress));

        var cacheKey = $"geo_cf_{ipAddress}";
        try
        {
            if (_cache.TryGetValue<GeolocationInfo>(cacheKey, out var cached))
                return Task.FromResult<GeolocationInfo?>(cached);
        }
        catch { }

        var geoInfo = new GeolocationInfo { IpAddress = ipAddress };

        ApplyCloudflareHeaders(geoInfo, ipAddress);

        if (ShouldUseMaxMindFallback(geoInfo) && _mmdbReader != null)
            ApplyMaxMindFallback(geoInfo, ipAddress);

        ApplyIntelligentDefaults(geoInfo);

        try
        {
            _cache.Set(cacheKey, geoInfo, TimeSpan.FromHours(6));
        }
        catch { }

        return Task.FromResult<GeolocationInfo?>(geoInfo);
    }

    private void ApplyCloudflareHeaders(GeolocationInfo geoInfo, string ipAddress)
    {
        var httpContext = _httpContextAccessor.HttpContext;
        if (httpContext == null)
            return;

        var headers = httpContext.Request.Headers;

        var cfCountry = headers["CF-IPCountry"].ToString();
        if (!string.IsNullOrWhiteSpace(cfCountry) && cfCountry.Length == 2)
        {
            geoInfo.CountryCode = cfCountry.ToUpperInvariant();
            try
            {
                var regionInfo = new RegionInfo(geoInfo.CountryCode);
                geoInfo.Country = regionInfo.EnglishName;
            }
            catch
            {
                geoInfo.Country = geoInfo.CountryCode;
            }
        }

        var cfCity = headers["CF-IPCity"].ToString();
        if (!string.IsNullOrWhiteSpace(cfCity))
            geoInfo.City = Uri.UnescapeDataString(cfCity);

        var cfRegion = headers["CF-Region"].ToString();
        if (!string.IsNullOrWhiteSpace(cfRegion))
            geoInfo.Region = cfRegion;

        var cfLatitude = headers["CF-IPLatitude"].ToString();
        var cfLongitude = headers["CF-IPLongitude"].ToString();

        if (
            double.TryParse(
                cfLatitude,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out var lat
            )
        )
            geoInfo.Latitude = lat;

        if (
            double.TryParse(
                cfLongitude,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out var lng
            )
        )
            geoInfo.Longitude = lng;

        if (!string.IsNullOrEmpty(cfCountry))
        {
            _logger.LogDebug(
                "Cloudflare geolocation for {IpAddress}: {Country}, {City}",
                ipAddress,
                geoInfo.Country,
                geoInfo.City
            );
        }
    }

    private bool ShouldUseMaxMindFallback(GeolocationInfo geoInfo)
    {
        return string.IsNullOrEmpty(geoInfo.Country)
            || (string.IsNullOrEmpty(geoInfo.City) && geoInfo.Latitude == null);
    }

    private void ApplyMaxMindFallback(GeolocationInfo geoInfo, string ipAddress)
    {
        try
        {
            if (!IPAddress.TryParse(ipAddress, out var parsedIp))
                return;

            var response = _mmdbReader!.City(parsedIp);

            if (string.IsNullOrEmpty(geoInfo.Country))
            {
                geoInfo.Country = response.Country?.Name;
                geoInfo.CountryCode = response.Country?.IsoCode;
            }
            if (string.IsNullOrEmpty(geoInfo.City))
                geoInfo.City = response.City?.Name;
            if (string.IsNullOrEmpty(geoInfo.Region))
                geoInfo.Region = response.MostSpecificSubdivision?.Name;
            if (geoInfo.Latitude == null && response.Location?.Latitude != null)
            {
                geoInfo.Latitude = response.Location.Latitude;
                geoInfo.Longitude = response.Location.Longitude;
            }
            if (string.IsNullOrEmpty(geoInfo.Timezone))
                geoInfo.Timezone = response.Location?.TimeZone;
        }
        catch (MaxMind.GeoIP2.Exceptions.AddressNotFoundException) { }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "MaxMind fallback failed for {IpAddress}", ipAddress);
        }
    }

    private void ApplyIntelligentDefaults(GeolocationInfo geoInfo)
    {
        if (string.IsNullOrEmpty(geoInfo.Timezone) && !string.IsNullOrEmpty(geoInfo.CountryCode))
            geoInfo.Timezone = GetTimezoneFromCountry(geoInfo.CountryCode);

        if (geoInfo.Latitude == null && !string.IsNullOrEmpty(geoInfo.CountryCode))
        {
            var coords = GetDefaultCoordinatesForCountry(geoInfo.CountryCode);
            if (coords.HasValue)
            {
                geoInfo.Latitude = coords.Value.Lat;
                geoInfo.Longitude = coords.Value.Lng;
                if (string.IsNullOrEmpty(geoInfo.City))
                    geoInfo.City = GetDefaultCityForCountry(geoInfo.CountryCode);
            }
        }

        geoInfo.Country ??= "Unknown";
        geoInfo.CountryCode ??= "??";
        geoInfo.City ??= "Unknown";
        geoInfo.Region ??= "Unknown";
        geoInfo.Timezone ??= "UTC";
        geoInfo.ISP ??= "Unknown ISP";
    }

    private (double Lat, double Lng)? GetDefaultCoordinatesForCountry(string countryCode)
    {
        return countryCode.ToUpperInvariant() switch
        {
            "DO" => (18.4861, -69.9312),
            "US" => (39.8283, -98.5795),
            "CA" => (56.1304, -106.3468),
            "MX" => (23.6345, -102.5528),
            "BR" => (-14.2350, -51.9253),
            "AR" => (-38.4161, -63.6167),
            "CL" => (-35.6751, -71.5430),
            "CO" => (4.5709, -74.2973),
            "PE" => (-9.1900, -75.0152),
            "CR" => (9.7489, -83.7534),
            "PA" => (8.5380, -80.7821),
            "GB" => (55.3781, -3.4360),
            "DE" => (51.1657, 10.4515),
            "FR" => (46.6034, 1.8883),
            "ES" => (40.4637, -3.7492),
            "IT" => (41.8719, 12.5674),
            "NL" => (52.1326, 5.2913),
            "JP" => (36.2048, 138.2529),
            "AU" => (-25.2744, 133.7751),
            _ => null,
        };
    }

    private string GetDefaultCityForCountry(string countryCode)
    {
        return countryCode.ToUpperInvariant() switch
        {
            "DO" => "Santo Domingo",
            "US" => "New York",
            "CA" => "Toronto",
            "MX" => "Mexico City",
            "BR" => "Sao Paulo",
            "AR" => "Buenos Aires",
            "CL" => "Santiago",
            "CO" => "Bogota",
            "PE" => "Lima",
            "CR" => "San Jose",
            "PA" => "Panama City",
            "GB" => "London",
            "DE" => "Berlin",
            "FR" => "Paris",
            "ES" => "Madrid",
            "IT" => "Rome",
            "NL" => "Amsterdam",
            "JP" => "Tokyo",
            "AU" => "Sydney",
            _ => "Unknown",
        };
    }

    private string GetTimezoneFromCountry(string? countryCode)
    {
        return countryCode?.ToUpperInvariant() switch
        {
            "DO" => "America/Santo_Domingo",
            "US" => "America/New_York",
            "CA" => "America/Toronto",
            "MX" => "America/Mexico_City",
            "BR" => "America/Sao_Paulo",
            "AR" => "America/Argentina/Buenos_Aires",
            "CL" => "America/Santiago",
            "CO" => "America/Bogota",
            "PE" => "America/Lima",
            "CR" => "America/Costa_Rica",
            "PA" => "America/Panama",
            "GB" => "Europe/London",
            "DE" => "Europe/Berlin",
            "FR" => "Europe/Paris",
            "ES" => "Europe/Madrid",
            "IT" => "Europe/Rome",
            "NL" => "Europe/Amsterdam",
            "PT" => "Europe/Lisbon",
            "PL" => "Europe/Warsaw",
            "RU" => "Europe/Moscow",
            "JP" => "Asia/Tokyo",
            "CN" => "Asia/Shanghai",
            "KR" => "Asia/Seoul",
            "IN" => "Asia/Kolkata",
            "TH" => "Asia/Bangkok",
            "SG" => "Asia/Singapore",
            "AU" => "Australia/Sydney",
            "NZ" => "Pacific/Auckland",
            _ => "UTC",
        };
    }

    public async Task<string> GetLocationDisplayAsync(string ipAddress)
    {
        var geoInfo = await GetLocationInfoAsync(ipAddress);

        if (geoInfo == null)
            return "Unknown Location";
        if (geoInfo.Country == "Local")
            return "Local Development";

        var parts = new List<string>();

        if (!string.IsNullOrEmpty(geoInfo.City) && geoInfo.City != "Unknown")
            parts.Add(geoInfo.City);
        if (
            !string.IsNullOrEmpty(geoInfo.Region)
            && geoInfo.Region != geoInfo.City
            && geoInfo.Region != "Unknown"
        )
            parts.Add(geoInfo.Region);
        if (!string.IsNullOrEmpty(geoInfo.Country) && geoInfo.Country != "Unknown")
            parts.Add(geoInfo.Country);

        var location = string.Join(", ", parts);
        return string.IsNullOrEmpty(location) ? "Unknown Location" : location;
    }

    private static GeolocationInfo CreateLocalGeolocationInfo(string ipAddress)
    {
        return new GeolocationInfo
        {
            IpAddress = ipAddress,
            Country = "Local",
            CountryCode = "LC",
            City = "Development",
            Region = "Local Development",
            Latitude = 0,
            Longitude = 0,
            Timezone = TimeZoneInfo.Local.Id,
            ISP = "Local Network",
        };
    }

    private static bool IsLocalIpAddress(string ipAddress)
    {
        if (string.IsNullOrWhiteSpace(ipAddress))
            return true;

        var localIndicators = new[] { "::1", "127.0.0.1", "localhost", "0.0.0.0", "unknown" };
        if (localIndicators.Contains(ipAddress, StringComparer.OrdinalIgnoreCase))
            return true;

        if (!IPAddress.TryParse(ipAddress, out var parsedIp))
            return true;

        var bytes = parsedIp.GetAddressBytes();
        if (bytes.Length == 4)
        {
            if (bytes[0] == 192 && bytes[1] == 168)
                return true;
            if (bytes[0] == 10)
                return true;
            if (bytes[0] == 172 && bytes[1] >= 16 && bytes[1] <= 31)
                return true;
            if (bytes[0] == 127)
                return true;
            if (bytes[0] == 169 && bytes[1] == 254)
                return true;
            if (bytes[0] == 100 && bytes[1] >= 64 && bytes[1] <= 127)
                return true;
        }

        return false;
    }

    public void Dispose()
    {
        _mmdbReader?.Dispose();
    }
}

public class GeolocationInfo
{
    public string IpAddress { get; set; } = string.Empty;
    public string? Country { get; set; }
    public string? CountryCode { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public string? Timezone { get; set; }
    public string? ISP { get; set; }

    public string GetLocationKey()
    {
        if (Country == "Local")
            return "local-dev";

        var parts = new List<string>();
        if (!string.IsNullOrEmpty(Country) && Country != "Unknown")
            parts.Add(Country.ToLowerInvariant());
        if (!string.IsNullOrEmpty(City) && City != "Unknown")
            parts.Add(City.ToLowerInvariant());

        return parts.Any() ? string.Join("-", parts) : "unknown";
    }

    public (string? Lat, string? Lng) GetCoordinatesAsString()
    {
        return (
            Latitude?.ToString("F6", System.Globalization.CultureInfo.InvariantCulture),
            Longitude?.ToString("F6", System.Globalization.CultureInfo.InvariantCulture)
        );
    }
}
