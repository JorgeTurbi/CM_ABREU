using System.Security.Claims;
using ApiCm.Commons.Utils;
using ApiCm.DTOs.Auth;
using ApiCm.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiCm.Controllers;

[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName = "Auth")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    private readonly IUserService _userService;
    private readonly ILogger<AuthController> _logger;

    public AuthController(
        IAuthService authService,
        IUserService userService,
        ILogger<AuthController> logger
    )
    {
        _authService = authService;
        _userService = userService;
        _logger = logger;
    }

    /// Iniciar sesion
    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDTO request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(
                new
                {
                    success = false,
                    message = "Invalid request data",
                    errors = ModelState
                        .Values.SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)
                        .ToList(),
                }
            );
        }

        var ipAddress = IpAddressHelper.GetClientIp(HttpContext);
        var userAgent = HttpContext.Request.Headers.UserAgent.ToString();

        var result = await _authService.LoginAsync(request, ipAddress, userAgent);

        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    /// Refrescar token de acceso
    [AllowAnonymous]
    [HttpPost("refresh-token")]
    public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequestDTO request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(
                new
                {
                    success = false,
                    message = "Invalid request data",
                    errors = ModelState
                        .Values.SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)
                        .ToList(),
                }
            );
        }

        var ipAddress = IpAddressHelper.GetClientIp(HttpContext);
        var userAgent = HttpContext.Request.Headers.UserAgent.ToString();

        var result = await _authService.RefreshTokenAsync(
            request.RefreshToken,
            ipAddress,
            userAgent
        );

        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    /// Cerrar sesion actual
    [Authorize]
    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        var sessionIdString = HttpContext.Items["SessionId"]?.ToString();

        if (
            string.IsNullOrEmpty(sessionIdString)
            || !Guid.TryParse(sessionIdString, out var sessionId)
        )
        {
            return BadRequest(new { success = false, message = "Invalid session" });
        }

        var result = await _authService.LogoutAsync(sessionId);

        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    /// Cerrar todas las sesiones del usuario
    [Authorize]
    [HttpPost("logout-all")]
    public async Task<IActionResult> LogoutAll()
    {
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userIdClaim) || !Guid.TryParse(userIdClaim, out var userId))
        {
            return Unauthorized(new { success = false, message = "Invalid user token" });
        }

        var result = await _authService.LogoutAllAsync(userId);

        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    /// Obtener perfil del usuario autenticado
    [Authorize]
    [HttpGet("me")]
    public async Task<IActionResult> GetCurrentUser()
    {
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userIdClaim) || !Guid.TryParse(userIdClaim, out var userId))
        {
            return Unauthorized(new { success = false, message = "Invalid user token" });
        }

        var result = await _userService.GetCurrentProfileAsync(userId);

        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    /// Obtener usuario por ID
    [Authorize]
    [HttpGet("users/{id:guid}")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        var result = await _userService.GetByIdAsync(id);

        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    /// Obtener todos los usuarios
    [Authorize]
    [HttpGet("users")]
    public async Task<IActionResult> GetAllUsers()
    {
        var result = await _userService.GetAllAsync();

        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
