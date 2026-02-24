using ApiCm.DTOs.User;

namespace ApiCm.DTOs.Auth;

public class LoginResponseDTO
{
    public required string AccessToken { get; set; }
    public required DateTime ExpiresAt { get; set; }
    public required string RefreshToken { get; set; }
    public required Guid SessionId { get; set; }
    public required UserDTO User { get; set; }
}
