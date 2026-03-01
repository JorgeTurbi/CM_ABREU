using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.CuentasPorCobrar;

public class TipoDocCxcRepository : ITipoDocCxcRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<TipoDocCxcRepository> _logger;

    public TipoDocCxcRepository(CmAbreuDbContext context, ILogger<TipoDocCxcRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBTIPODOCCXC> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBTIPODOCCXC.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(t => t.CiaCodigo)
            .ThenBy(t => t.MonCodigo)
            .ThenBy(t => t.TdcTipo)
            .ThenBy(t => t.TdcCodigo)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBTIPODOCCXC?> GetByIdAsync(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBTIPODOCCXC.AsNoTracking()
            .FirstOrDefaultAsync(
                t =>
                    t.CiaCodigo == ciaCodigo
                    && t.MonCodigo == monCodigo
                    && t.TdcTipo == tdcTipo
                    && t.TdcCodigo == tdcCodigo,
                ct
            );
    }

    public async Task<TBTIPODOCCXC> CreateAsync(TBTIPODOCCXC entity, CancellationToken ct = default)
    {
        await _context.TBTIPODOCCXC.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Tipo documento CXC creado: Compania={Compania}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}",
            entity.CiaCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo
        );
        return entity;
    }

    public async Task<TBTIPODOCCXC> UpdateAsync(TBTIPODOCCXC entity, CancellationToken ct = default)
    {
        _context.TBTIPODOCCXC.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Tipo documento CXC actualizado: Compania={Compania}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}",
            entity.CiaCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo
        );
        return entity;
    }
}
