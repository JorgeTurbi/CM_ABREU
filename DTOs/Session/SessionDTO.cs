namespace ApiCm.DTOs.Session;

public class SessionDTO
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string? IpAddress { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string? Longitude { get; set; }
    public string? Location { get; set; }
    public string? Device { get; set; }
    public DateTime ExpireTokenRequest { get; set; }
    public bool IsRevoke { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
