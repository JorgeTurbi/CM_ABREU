using ApiCm.Commons;
using ApiCm.DTOs.User;

namespace ApiCm.Services.Interfaces;

public interface IUserService
{
    Task<ApiResponse<UserProfileDTO>> GetCurrentProfileAsync(Guid userId);
    Task<ApiResponse<UserDTO>> GetByIdAsync(Guid userId);
    Task<ApiResponse<List<UserDTO>>> GetAllAsync();
}
