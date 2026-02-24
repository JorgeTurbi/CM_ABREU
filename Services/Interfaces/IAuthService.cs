using ApiCm.Commons;
using ApiCm.DTOs.Auth;

namespace ApiCm.Services.Interfaces;

public interface IAuthService
{
    Task<ApiResponse<LoginResponseDTO>> LoginAsync(
        LoginRequestDTO request,
        string ipAddress,
        string userAgent
    );
    Task<ApiResponse<LoginResponseDTO>> RefreshTokenAsync(
        string refreshToken,
        string ipAddress,
        string userAgent
    );
    Task<ApiResponse<bool>> LogoutAsync(Guid sessionId);
    Task<ApiResponse<bool>> LogoutAllAsync(Guid userId);
}
