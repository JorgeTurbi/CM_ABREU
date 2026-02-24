using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ApiCm.Commons.Settings;
using ApiCm.DTOs.Auth;
using ApiCm.Entities;
using ApiCm.Services.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ApiCm.Services;

public class TokenService : ITokenService
{
    private readonly JwtSettings _jwtSettings;
    private readonly ILogger<TokenService> _logger;

    public TokenService(IOptions<JwtSettings> jwtOptions, ILogger<TokenService> logger)
    {
        _jwtSettings = jwtOptions.Value;
        _logger = logger;
    }

    public TokenResult Generate(TokenGenerationRequest request)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
        var handler = new JwtSecurityTokenHandler();

        var displayName = BuildDisplayName(
            request.User.Name,
            request.User.LastName,
            request.User.UserName,
            request.User.Email
        );

        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, request.User.UserId.ToString()),
            new(JwtRegisteredClaimNames.Email, request.User.Email),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString()),
            new(ClaimTypes.NameIdentifier, request.User.UserId.ToString()),
            new(ClaimTypes.Email, request.User.Email),
            new(ClaimTypes.Name, displayName),
            new("username", request.User.UserName),
            new("sid", request.Session.SessionId.ToString()),
            new("ip", request.Session.IpAddress),
        };

        if (!string.IsNullOrWhiteSpace(request.User.Name))
            claims.Add(new Claim(ClaimTypes.GivenName, request.User.Name));

        if (!string.IsNullOrWhiteSpace(request.User.LastName))
            claims.Add(new Claim(ClaimTypes.Surname, request.User.LastName));

        var expiresAt = DateTime.UtcNow.Add(request.LifeTime);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = expiresAt,
            Issuer = _jwtSettings.Issuer,
            Audience = _jwtSettings.Audience,
            SigningCredentials = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256Signature
            ),
        };

        var token = handler.CreateToken(tokenDescriptor);
        var tokenString = handler.WriteToken(token);

        _logger.LogInformation(
            "Token generated for user {UserId} ({Email}) with session {SessionId}",
            request.User.UserId,
            request.User.Email,
            request.Session.SessionId
        );

        return new TokenResult(tokenString, expiresAt, request.Session.SessionId);
    }

    public Task<TokenResult> GenerateForUserAsync(
        User user,
        Guid sessionId,
        string ipAddress,
        string userAgent
    )
    {
        var userInfo = new UserTokenInfo(
            UserId: user.Id,
            Email: user.Email,
            UserName: user.UserName,
            Name: user.Name,
            LastName: user.LastName
        );

        var sessionInfo = new SessionTokenInfo(
            SessionId: sessionId,
            IpAddress: ipAddress,
            UserAgent: userAgent
        );

        var request = new TokenGenerationRequest(
            User: userInfo,
            Session: sessionInfo,
            LifeTime: _jwtSettings.DefaultTokenLifetime
        );

        return Task.FromResult(Generate(request));
    }

    private static string BuildDisplayName(
        string? name,
        string? lastName,
        string userName,
        string email
    )
    {
        if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(lastName))
            return $"{name} {lastName}";

        if (!string.IsNullOrWhiteSpace(name))
            return name;

        if (!string.IsNullOrWhiteSpace(userName))
            return userName;

        return email.Split('@')[0];
    }
}
