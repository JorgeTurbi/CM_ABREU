using System.IdentityModel.Tokens.Jwt;
using ApiCm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace ApiCm.Middleware;

public sealed class JwtSessionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<JwtSessionMiddleware> _logger;

    public JwtSessionMiddleware(RequestDelegate next, ILogger<JwtSessionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(
        HttpContext context,
        ApplicationDbContext dbContext,
        IMemoryCache cache
    )
    {
        var authHeader = context.Request.Headers.Authorization.FirstOrDefault();

        if (
            string.IsNullOrEmpty(authHeader)
            || !authHeader.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase)
        )
        {
            await _next(context);
            return;
        }

        try
        {
            var token = authHeader.Substring("Bearer ".Length).Trim();
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);

            var sessionIdClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == "sid");

            if (sessionIdClaim == null || !Guid.TryParse(sessionIdClaim.Value, out var sessionId))
            {
                _logger.LogWarning("Token without valid 'sid' claim");
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Invalid token: missing session ID");
                return;
            }

            var cacheKey = $"session_valid:{sessionId}";
            bool? isValid = null;

            if (cache.TryGetValue(cacheKey, out bool cachedResult))
            {
                isValid = cachedResult;
                _logger.LogDebug(
                    "Session validation cache hit for {SessionId}: {IsValid}",
                    sessionId,
                    cachedResult
                );
            }

            if (!isValid.HasValue)
            {
                isValid = await ValidateSessionInDatabaseAsync(
                    dbContext,
                    sessionId,
                    context.RequestAborted
                );

                cache.Set(cacheKey, isValid.Value, TimeSpan.FromSeconds(5));

                _logger.LogDebug(
                    "Session {SessionId} validated from database: {IsValid}",
                    sessionId,
                    isValid.Value
                );
            }

            if (!isValid.Value)
            {
                _logger.LogWarning("Session {SessionId} is revoked or expired", sessionId);
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Session revoked or expired");
                return;
            }

            context.Items["SessionId"] = sessionId.ToString();

            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error validating session in middleware");
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Invalid token");
        }
    }

    private static async Task<bool> ValidateSessionInDatabaseAsync(
        ApplicationDbContext dbContext,
        Guid sessionId,
        CancellationToken ct
    )
    {
        return await dbContext.Sessions.AnyAsync(
            s =>
                s.Id == sessionId
                && s.IsRevoke == false
                && s.IsDeleted == false
                && s.ExpireTokenRequest > DateTime.UtcNow,
            ct
        );
    }
}

public static class JwtSessionMiddlewareExtensions
{
    public static IApplicationBuilder UseJwtSessionValidation(this IApplicationBuilder app)
    {
        return app.UseMiddleware<JwtSessionMiddleware>();
    }
}
