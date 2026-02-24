using ApiCm.Commons;
using ApiCm.Commons.Settings;
using ApiCm.DTOs.Auth;
using ApiCm.DTOs.User;
using ApiCm.Entities;
using ApiCm.Repositories.Interfaces;
using ApiCm.Services.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Options;

namespace ApiCm.Services;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly ISessionRepository _sessionRepository;
    private readonly IPasswordHashService _passwordHash;
    private readonly ITokenService _tokenService;
    private readonly IGeolocationService _geolocationService;
    private readonly IMapper _mapper;
    private readonly ILogger<AuthService> _logger;
    private readonly JwtSettings _jwtSettings;

    public AuthService(
        IUserRepository userRepository,
        ISessionRepository sessionRepository,
        IPasswordHashService passwordHash,
        ITokenService tokenService,
        IGeolocationService geolocationService,
        IMapper mapper,
        ILogger<AuthService> logger,
        IOptions<JwtSettings> jwtOptions
    )
    {
        _userRepository = userRepository;
        _sessionRepository = sessionRepository;
        _passwordHash = passwordHash;
        _tokenService = tokenService;
        _geolocationService = geolocationService;
        _mapper = mapper;
        _logger = logger;
        _jwtSettings = jwtOptions.Value;
    }

    public async Task<ApiResponse<LoginResponseDTO>> LoginAsync(
        LoginRequestDTO request,
        string ipAddress,
        string userAgent
    )
    {
        try
        {
            // 1. Buscar usuario
            var user = await _userRepository.GetByEmailOrUsernameAsync(request.EmailOrUsername);

            if (user == null)
            {
                _logger.LogWarning(
                    "Login failed: User not found with identifier: {Identifier}",
                    request.EmailOrUsername
                );
                return new ApiResponse<LoginResponseDTO>(false, "Invalid credentials")
                {
                    StatusCode = 401,
                };
            }

            // 2. Verificar si esta activo
            if (!user.IsActive)
            {
                _logger.LogWarning("Login failed: User {UserId} is inactive", user.Id);
                return new ApiResponse<LoginResponseDTO>(false, "User account is inactive")
                {
                    StatusCode = 403,
                };
            }

            // 3. Verificar contrasena
            if (!_passwordHash.Verify(request.Password, user.Password))
            {
                _logger.LogWarning("Login failed: Invalid password for user {UserId}", user.Id);
                return new ApiResponse<LoginResponseDTO>(false, "Invalid credentials")
                {
                    StatusCode = 401,
                };
            }

            // 4. Obtener informacion de geolocalizacion
            var geoInfo = await _geolocationService.GetLocationInfoAsync(ipAddress);
            var locationDisplay = await _geolocationService.GetLocationDisplayAsync(ipAddress);
            var (latitude, longitude) = geoInfo?.GetCoordinatesAsString() ?? (null, null);

            // 5. Determinar tiempos de vida
            var tokenLifetime = request.RememberMe
                ? TimeSpan.FromDays(30)
                : _jwtSettings.DefaultTokenLifetime;

            var refreshTokenLifetime = request.RememberMe
                ? _jwtSettings.RefreshTokenLifetimeRememberMe
                : _jwtSettings.RefreshTokenLifetime;

            // 6. Generar refresh token como GUID
            var refreshToken = Guid.NewGuid().ToString("N");

            // 7. Crear sesion
            var session = new Session
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                TokenRequest = string.Empty,
                ExpireTokenRequest = DateTime.UtcNow.Add(tokenLifetime),
                TokenRefresh = refreshToken,
                ExpireTokenRefresh = DateTime.UtcNow.Add(refreshTokenLifetime),
                IpAddress = ipAddress,
                Country = geoInfo?.Country,
                City = geoInfo?.City,
                Region = geoInfo?.Region,
                Latitude = latitude,
                Longitude = longitude,
                Location = locationDisplay,
                Device = userAgent,
                IsRevoke = false,
            };

            var createdSession = await _sessionRepository.CreateAsync(session);

            // 8. Generar token JWT
            var tokenResult = await _tokenService.GenerateForUserAsync(
                user,
                createdSession.Id,
                ipAddress,
                userAgent
            );

            // 9. Actualizar sesion con el access token
            createdSession.TokenRequest = tokenResult.AccessToken;
            await _sessionRepository.UpdateAsync(createdSession);

            // 10. Mapear UserDTO
            var userDto = _mapper.Map<UserDTO>(user);

            // 11. Crear respuesta
            var response = new LoginResponseDTO
            {
                AccessToken = tokenResult.AccessToken,
                ExpiresAt = tokenResult.ExpiresAt,
                RefreshToken = refreshToken,
                SessionId = tokenResult.SessionId,
                User = userDto,
            };

            _logger.LogInformation(
                "User {UserId} logged in successfully from {IpAddress}",
                user.Id,
                ipAddress
            );

            return new ApiResponse<LoginResponseDTO>(true, "Login successful", response)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error during login process");
            return new ApiResponse<LoginResponseDTO>(false, "An error occurred during login")
            {
                StatusCode = 500,
                Errors = new List<string> { ex.Message },
            };
        }
    }

    public async Task<ApiResponse<LoginResponseDTO>> RefreshTokenAsync(
        string refreshToken,
        string ipAddress,
        string userAgent
    )
    {
        try
        {
            // 1. Buscar sesion por refresh token (no revocada, no expirada, no eliminada)
            var session = await _sessionRepository.GetByRefreshTokenAsync(refreshToken);

            if (session == null)
            {
                _logger.LogWarning("Refresh token failed: Invalid or expired refresh token");
                return new ApiResponse<LoginResponseDTO>(false, "Invalid or expired refresh token")
                {
                    StatusCode = 401,
                };
            }

            // 2. Buscar el usuario
            var user = await _userRepository.GetByIdAsync(session.UserId);

            if (user == null || !user.IsActive)
            {
                _logger.LogWarning(
                    "Refresh token failed: User {UserId} not found or inactive",
                    session.UserId
                );
                return new ApiResponse<LoginResponseDTO>(false, "User not found or inactive")
                {
                    StatusCode = 401,
                };
            }

            // 3. Generar nuevo access token JWT
            var tokenResult = await _tokenService.GenerateForUserAsync(
                user,
                session.Id,
                ipAddress,
                userAgent
            );

            // 4. Generar nuevo refresh token (rotacion de refresh token)
            var newRefreshToken = Guid.NewGuid().ToString("N");

            // 5. Actualizar la sesion con nuevos tokens y nuevos tiempos
            session.TokenRequest = tokenResult.AccessToken;
            session.ExpireTokenRequest = tokenResult.ExpiresAt;
            session.TokenRefresh = newRefreshToken;
            session.ExpireTokenRefresh = DateTime.UtcNow.Add(_jwtSettings.RefreshTokenLifetime);
            session.IpAddress = ipAddress;
            session.Device = userAgent;

            await _sessionRepository.UpdateAsync(session);

            // 6. Mapear UserDTO
            var userDto = _mapper.Map<UserDTO>(user);

            // 7. Crear respuesta
            var response = new LoginResponseDTO
            {
                AccessToken = tokenResult.AccessToken,
                ExpiresAt = tokenResult.ExpiresAt,
                RefreshToken = newRefreshToken,
                SessionId = session.Id,
                User = userDto,
            };

            _logger.LogInformation(
                "Token refreshed successfully for user {UserId}, session {SessionId}",
                user.Id,
                session.Id
            );

            return new ApiResponse<LoginResponseDTO>(true, "Token refreshed successfully", response)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error during token refresh");
            return new ApiResponse<LoginResponseDTO>(
                false,
                "An error occurred during token refresh"
            )
            {
                StatusCode = 500,
                Errors = new List<string> { ex.Message },
            };
        }
    }

    public async Task<ApiResponse<bool>> LogoutAsync(Guid sessionId)
    {
        try
        {
            var session = await _sessionRepository.GetByIdAsync(sessionId);

            if (session == null)
            {
                return new ApiResponse<bool>(false, "Session not found") { StatusCode = 404 };
            }

            await _sessionRepository.RevokeSessionAsync(sessionId);

            _logger.LogInformation("Session {SessionId} logged out successfully", sessionId);

            return new ApiResponse<bool>(true, "Logged out successfully", true)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error during logout for session {SessionId}", sessionId);
            return new ApiResponse<bool>(false, "An error occurred during logout")
            {
                StatusCode = 500,
                Errors = new List<string> { ex.Message },
            };
        }
    }

    public async Task<ApiResponse<bool>> LogoutAllAsync(Guid userId)
    {
        try
        {
            await _sessionRepository.RevokeAllUserSessionsAsync(userId);

            _logger.LogInformation("All sessions revoked for user {UserId}", userId);

            return new ApiResponse<bool>(true, "All sessions closed successfully", true)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error during logout-all for user {UserId}", userId);
            return new ApiResponse<bool>(false, "An error occurred during logout")
            {
                StatusCode = 500,
                Errors = new List<string> { ex.Message },
            };
        }
    }
}
