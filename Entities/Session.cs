using ApiCm.Commons;

namespace ApiCm.Entities;

public class Session : BaseEntity
{
    public Guid UserId { get; set; }
    public required string TokenRequest { get; set; }
    public required DateTime ExpireTokenRequest { get; set; }
    public string? TokenRefresh { get; set; }
    public DateTime? ExpireTokenRefresh { get; set; }
    public string? IpAddress { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
    public string? Location { get; set; }
    public string? Device { get; set; }
    public bool IsRevoke { get; set; } = false;
    public virtual User User { get; set; } = null!;
}
