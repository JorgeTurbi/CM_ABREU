using System.ComponentModel.DataAnnotations;

namespace ApiCm.DTOs.Auth;

public class RefreshTokenRequestDTO
{
    [Required]
    public required string RefreshToken { get; set; }
}
