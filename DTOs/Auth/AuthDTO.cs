namespace ApiCm.DTOs.Auth;

public sealed record UserTokenInfo(
    Guid UserId,
    string Email,
    string UserName,
    string? Name,
    string? LastName
);

public sealed record SessionTokenInfo(Guid SessionId, string IpAddress, string UserAgent);

public sealed record TokenGenerationRequest(
    UserTokenInfo User,
    SessionTokenInfo Session,
    TimeSpan LifeTime
);

public sealed record TokenResult(string AccessToken, DateTime ExpiresAt, Guid SessionId);
