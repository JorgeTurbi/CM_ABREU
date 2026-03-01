using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.Clientes;

public class CteDefectoRepository : ICteDefectoRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<CteDefectoRepository> _logger;

    public CteDefectoRepository(CmAbreuDbContext context, ILogger<CteDefectoRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBCTEDEFECTO> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBCTEDEFECTO.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(c => c.CiaCodigo)
            .ThenBy(c => c.CdfLocalExterior)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBCTEDEFECTO?> GetByIdAsync(
        int ciaCodigo,
        string cdfLocalExterior,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBCTEDEFECTO.AsNoTracking()
            .FirstOrDefaultAsync(
                c => c.CiaCodigo == ciaCodigo && c.CdfLocalExterior == cdfLocalExterior,
                ct
            );
    }

    public async Task<TBCTEDEFECTO> CreateAsync(TBCTEDEFECTO entity, CancellationToken ct = default)
    {
        await _context.TBCTEDEFECTO.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Cliente defecto creado: Compania={Compania}, LocalExterior={LocalExterior}",
            entity.CiaCodigo,
            entity.CdfLocalExterior
        );
        return entity;
    }

    public async Task<TBCTEDEFECTO> UpdateAsync(TBCTEDEFECTO entity, CancellationToken ct = default)
    {
        _context.TBCTEDEFECTO.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Cliente defecto actualizado: Compania={Compania}, LocalExterior={LocalExterior}",
            entity.CiaCodigo,
            entity.CdfLocalExterior
        );
        return entity;
    }
}
