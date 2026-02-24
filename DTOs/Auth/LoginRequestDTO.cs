using System.ComponentModel.DataAnnotations;

namespace ApiCm.DTOs.Auth;

public class LoginRequestDTO
{
    [Required(ErrorMessage = "Email or Username is required")]
    public required string EmailOrUsername { get; set; }

    [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
    public required string Password { get; set; }

    public bool RememberMe { get; set; } = false;
}
