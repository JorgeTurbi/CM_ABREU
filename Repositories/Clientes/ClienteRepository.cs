using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.Clientes;

public class ClienteRepository : IClienteRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<ClienteRepository> _logger;

    public ClienteRepository(CmAbreuDbContext context, ILogger<ClienteRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBCLIENTE> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBCLIENTE.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(c => c.CiaCodigo)
            .ThenBy(c => c.CteCodigo)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBCLIENTE?> GetByIdAsync(
        int ciaCodigo,
        string cteCodigo,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBCLIENTE.AsNoTracking()
            .FirstOrDefaultAsync(c => c.CiaCodigo == ciaCodigo && c.CteCodigo == cteCodigo, ct);
    }

    public async Task<TBCLIENTE> CreateAsync(TBCLIENTE entity, CancellationToken ct = default)
    {
        await _context.TBCLIENTE.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Cliente creado: Compania={Compania}, Codigo={Codigo}, Nombre={Nombre}",
            entity.CiaCodigo,
            entity.CteCodigo,
            entity.CteNombre
        );
        return entity;
    }

    public async Task<TBCLIENTE> UpdateAsync(TBCLIENTE entity, CancellationToken ct = default)
    {
        _context.TBCLIENTE.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Cliente actualizado: Compania={Compania}, Codigo={Codigo}",
            entity.CiaCodigo,
            entity.CteCodigo
        );
        return entity;
    }

    public async Task<bool> DeleteAsync(
        int ciaCodigo,
        string cteCodigo,
        CancellationToken ct = default
    )
    {
        var entity = await _context.TBCLIENTE.FirstOrDefaultAsync(
            c => c.CiaCodigo == ciaCodigo && c.CteCodigo == cteCodigo,
            ct
        );

        if (entity == null)
            return false;

        _context.TBCLIENTE.Remove(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Cliente eliminado: Compania={Compania}, Codigo={Codigo}",
            ciaCodigo,
            cteCodigo
        );
        return true;
    }
}
