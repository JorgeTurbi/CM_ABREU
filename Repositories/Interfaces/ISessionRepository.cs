using ApiCm.Entities;

namespace ApiCm.Repositories.Interfaces;

public interface ISessionRepository
{
    Task<Session?> GetByIdAsync(Guid id, CancellationToken ct = default);
    Task<Session?> GetByRefreshTokenAsync(string refreshToken, CancellationToken ct = default);
    Task<List<Session>> GetActiveSessionsByUserIdAsync(Guid userId, CancellationToken ct = default);
    Task<Session> CreateAsync(Session session, CancellationToken ct = default);
    Task<Session> UpdateAsync(Session session, CancellationToken ct = default);
    Task RevokeSessionAsync(Guid sessionId, CancellationToken ct = default);
    Task RevokeAllUserSessionsAsync(Guid userId, CancellationToken ct = default);
    Task<bool> IsSessionValidAsync(Guid sessionId, CancellationToken ct = default);
    Task<int> GetActiveSessionCountAsync(Guid userId, CancellationToken ct = default);
}
