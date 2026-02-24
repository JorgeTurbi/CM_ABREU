namespace ApiCm.Commons.Settings;

public class JwtSettings
{
    public string SecretKey { get; set; } = string.Empty;
    public bool ValidateIssuer { get; set; }
    public bool ValidateAudience { get; set; }
    public bool ValidateIssuerSigningKey { get; set; }
    public bool ValidateLifetime { get; set; }
    public string Issuer { get; set; } = string.Empty;
    public string Audience { get; set; } = string.Empty;
    public TimeSpan ClockSkew { get; set; } = TimeSpan.Zero;
    public TimeSpan DefaultTokenLifetime { get; set; } = TimeSpan.FromHours(8);
    public TimeSpan RefreshTokenLifetime { get; set; } = TimeSpan.FromDays(7);
    public TimeSpan RefreshTokenLifetimeRememberMe { get; set; } = TimeSpan.FromDays(60);
}
