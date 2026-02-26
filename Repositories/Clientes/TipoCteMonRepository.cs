using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.Clientes;

public class TipoCteMonRepository : ITipoCteMonRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<TipoCteMonRepository> _logger;

    public TipoCteMonRepository(CmAbreuDbContext context, ILogger<TipoCteMonRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBTIPOCTEMON> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBTIPOCTEMON.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(t => t.CiaCodigo)
            .ThenBy(t => t.TclCodigo)
            .ThenBy(t => t.MonCodigo)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBTIPOCTEMON?> GetByIdAsync(
        int ciaCodigo,
        int tclCodigo,
        int monCodigo,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBTIPOCTEMON.AsNoTracking()
            .FirstOrDefaultAsync(
                t =>
                    t.CiaCodigo == ciaCodigo
                    && t.TclCodigo == tclCodigo
                    && t.MonCodigo == monCodigo,
                ct
            );
    }

    public async Task<TBTIPOCTEMON> CreateAsync(TBTIPOCTEMON entity, CancellationToken ct = default)
    {
        await _context.TBTIPOCTEMON.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Tipo cliente moneda creado: Compania={Compania}, TipoCte={TipoCte}, Moneda={Moneda}",
            entity.CiaCodigo,
            entity.TclCodigo,
            entity.MonCodigo
        );
        return entity;
    }

    public async Task<TBTIPOCTEMON> UpdateAsync(TBTIPOCTEMON entity, CancellationToken ct = default)
    {
        _context.TBTIPOCTEMON.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Tipo cliente moneda actualizado: Compania={Compania}, TipoCte={TipoCte}, Moneda={Moneda}",
            entity.CiaCodigo,
            entity.TclCodigo,
            entity.MonCodigo
        );
        return entity;
    }

    public async Task<bool> DeleteAsync(
        int ciaCodigo,
        int tclCodigo,
        int monCodigo,
        CancellationToken ct = default
    )
    {
        var entity = await _context.TBTIPOCTEMON.FirstOrDefaultAsync(
            t => t.CiaCodigo == ciaCodigo && t.TclCodigo == tclCodigo && t.MonCodigo == monCodigo,
            ct
        );

        if (entity == null)
            return false;

        _context.TBTIPOCTEMON.Remove(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Tipo cliente moneda eliminado: Compania={Compania}, TipoCte={TipoCte}, Moneda={Moneda}",
            ciaCodigo,
            tclCodigo,
            monCodigo
        );
        return true;
    }
}
