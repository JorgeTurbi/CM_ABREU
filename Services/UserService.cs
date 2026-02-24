using ApiCm.Commons;
using ApiCm.DTOs.User;
using ApiCm.Repositories.Interfaces;
using ApiCm.Services.Interfaces;
using AutoMapper;

namespace ApiCm.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<UserService> _logger;

    public UserService(IUserRepository userRepository, IMapper mapper, ILogger<UserService> logger)
    {
        _userRepository = userRepository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<ApiResponse<UserProfileDTO>> GetCurrentProfileAsync(Guid userId)
    {
        try
        {
            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
            {
                return new ApiResponse<UserProfileDTO>(false, "User not found")
                {
                    StatusCode = 404,
                };
            }

            var profile = _mapper.Map<UserProfileDTO>(user);

            return new ApiResponse<UserProfileDTO>(true, "Profile retrieved successfully", profile)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving profile for user {UserId}", userId);
            return new ApiResponse<UserProfileDTO>(false, "An error occurred")
            {
                StatusCode = 500,
                Errors = new List<string> { ex.Message },
            };
        }
    }

    public async Task<ApiResponse<UserDTO>> GetByIdAsync(Guid userId)
    {
        try
        {
            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
            {
                return new ApiResponse<UserDTO>(false, "User not found") { StatusCode = 404 };
            }

            var userDto = _mapper.Map<UserDTO>(user);

            return new ApiResponse<UserDTO>(true, "User retrieved successfully", userDto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving user {UserId}", userId);
            return new ApiResponse<UserDTO>(false, "An error occurred")
            {
                StatusCode = 500,
                Errors = new List<string> { ex.Message },
            };
        }
    }

    public async Task<ApiResponse<List<UserDTO>>> GetAllAsync()
    {
        try
        {
            var users = await _userRepository.GetAllAsync();
            var userDtos = _mapper.Map<List<UserDTO>>(users);

            return new ApiResponse<List<UserDTO>>(true, "Users retrieved successfully", userDtos)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving all users");
            return new ApiResponse<List<UserDTO>>(false, "An error occurred")
            {
                StatusCode = 500,
                Errors = new List<string> { ex.Message },
            };
        }
    }
}
