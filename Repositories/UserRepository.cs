using ApiCm.Data;
using ApiCm.Entities;
using ApiCm.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<UserRepository> _logger;

    public UserRepository(ApplicationDbContext context, ILogger<UserRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<User?> GetByIdAsync(Guid id, CancellationToken ct = default)
    {
        return await _context
            .Users.AsNoTracking()
            .FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted, ct);
    }

    public async Task<User?> GetByEmailOrUsernameAsync(
        string emailOrUsername,
        CancellationToken ct = default
    )
    {
        return await _context
            .Users.AsNoTracking()
            .FirstOrDefaultAsync(
                u => (u.Email == emailOrUsername || u.UserName == emailOrUsername) && !u.IsDeleted,
                ct
            );
    }

    public async Task<List<User>> GetAllAsync(
        bool includeDeleted = false,
        CancellationToken ct = default
    )
    {
        var query = _context.Users.AsNoTracking();

        if (!includeDeleted)
            query = query.Where(u => !u.IsDeleted);

        return await query.OrderBy(u => u.Name).ThenBy(u => u.LastName).ToListAsync(ct);
    }

    public async Task<bool> ExistsByEmailAsync(string email, CancellationToken ct = default)
    {
        return await _context.Users.AnyAsync(u => u.Email == email && !u.IsDeleted, ct);
    }

    public async Task<bool> ExistsByUsernameAsync(string username, CancellationToken ct = default)
    {
        return await _context.Users.AnyAsync(u => u.UserName == username && !u.IsDeleted, ct);
    }
}
