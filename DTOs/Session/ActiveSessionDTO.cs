namespace ApiCm.DTOs.Session;

public class ActiveSessionDTO
{
    public Guid SessionId { get; set; }
    public string? Location { get; set; }
    public string? Device { get; set; }
    public string? IpAddress { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ExpiresAt { get; set; }
}
