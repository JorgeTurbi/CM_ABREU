using ApiCm.Entities;

namespace ApiCm.Repositories.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken ct = default);
    Task<User?> GetByEmailOrUsernameAsync(string emailOrUsername, CancellationToken ct = default);
    Task<List<User>> GetAllAsync(bool includeDeleted = false, CancellationToken ct = default);
    Task<bool> ExistsByEmailAsync(string email, CancellationToken ct = default);
    Task<bool> ExistsByUsernameAsync(string username, CancellationToken ct = default);
}
