using ApiCm.DTOs.Auth;
using ApiCm.Entities;

namespace ApiCm.Services.Interfaces;

public interface ITokenService
{
    TokenResult Generate(TokenGenerationRequest request);
    Task<TokenResult> GenerateForUserAsync(
        User user,
        Guid sessionId,
        string ipAddress,
        string userAgent
    );
}
