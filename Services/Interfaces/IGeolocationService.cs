using ApiCm.Services;

namespace ApiCm.Services.Interfaces;

public interface IGeolocationService
{
    Task<GeolocationInfo?> GetLocationInfoAsync(string ipAddress);
    Task<string> GetLocationDisplayAsync(string ipAddress);
}
