using ApiCm.Data;
using ApiCm.Entities;
using ApiCm.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories;

public class SessionRepository : ISessionRepository
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<SessionRepository> _logger;

    public SessionRepository(ApplicationDbContext context, ILogger<SessionRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<Session?> GetByIdAsync(Guid id, CancellationToken ct = default)
    {
        return await _context
            .Sessions.AsNoTracking()
            .FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted, ct);
    }

    public async Task<Session?> GetByRefreshTokenAsync(
        string refreshToken,
        CancellationToken ct = default
    )
    {
        return await _context.Sessions.FirstOrDefaultAsync(
            s =>
                s.TokenRefresh == refreshToken
                && !s.IsRevoke
                && !s.IsDeleted
                && s.ExpireTokenRefresh > DateTime.UtcNow,
            ct
        );
    }

    public async Task<List<Session>> GetActiveSessionsByUserIdAsync(
        Guid userId,
        CancellationToken ct = default
    )
    {
        var now = DateTime.UtcNow;

        return await _context
            .Sessions.AsNoTracking()
            .Where(s =>
                s.UserId == userId && !s.IsRevoke && !s.IsDeleted && s.ExpireTokenRequest > now
            )
            .OrderByDescending(s => s.CreatedAt)
            .ToListAsync(ct);
    }

    public async Task<Session> CreateAsync(Session session, CancellationToken ct = default)
    {
        session.CreatedAt = DateTime.UtcNow;
        await _context.Sessions.AddAsync(session, ct);
        await _context.SaveChangesAsync(ct);

        _logger.LogInformation(
            "Session created with ID: {SessionId} for User: {UserId}",
            session.Id,
            session.UserId
        );

        return session;
    }

    public async Task<Session> UpdateAsync(Session session, CancellationToken ct = default)
    {
        session.UpdatedAt = DateTime.UtcNow;
        _context.Sessions.Update(session);
        await _context.SaveChangesAsync(ct);

        _logger.LogInformation("Session updated with ID: {SessionId}", session.Id);
        return session;
    }

    public async Task RevokeSessionAsync(Guid sessionId, CancellationToken ct = default)
    {
        var session = await _context.Sessions.FirstOrDefaultAsync(
            s => s.Id == sessionId && !s.IsDeleted,
            ct
        );

        if (session != null)
        {
            session.IsRevoke = true;
            session.UpdatedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync(ct);

            _logger.LogInformation("Session revoked: {SessionId}", sessionId);
        }
    }

    public async Task RevokeAllUserSessionsAsync(Guid userId, CancellationToken ct = default)
    {
        var sessions = await _context
            .Sessions.Where(s => s.UserId == userId && !s.IsRevoke && !s.IsDeleted)
            .ToListAsync(ct);

        foreach (var session in sessions)
        {
            session.IsRevoke = true;
            session.UpdatedAt = DateTime.UtcNow;
        }

        await _context.SaveChangesAsync(ct);

        _logger.LogInformation(
            "All sessions revoked for User: {UserId}. Count: {Count}",
            userId,
            sessions.Count
        );
    }

    public async Task<bool> IsSessionValidAsync(Guid sessionId, CancellationToken ct = default)
    {
        var now = DateTime.UtcNow;

        return await _context.Sessions.AnyAsync(
            s => s.Id == sessionId && !s.IsRevoke && !s.IsDeleted && s.ExpireTokenRequest > now,
            ct
        );
    }

    public async Task<int> GetActiveSessionCountAsync(Guid userId, CancellationToken ct = default)
    {
        var now = DateTime.UtcNow;

        return await _context.Sessions.CountAsync(
            s => s.UserId == userId && !s.IsRevoke && !s.IsDeleted && s.ExpireTokenRequest > now,
            ct
        );
    }
}
