using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.Clientes;

public class TipoCteRepository : ITipoCteRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<TipoCteRepository> _logger;

    public TipoCteRepository(CmAbreuDbContext context, ILogger<TipoCteRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBTIPOCTE> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBTIPOCTE.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(t => t.CiaCodigo)
            .ThenBy(t => t.TclCodigo)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBTIPOCTE?> GetByIdAsync(
        int ciaCodigo,
        int tclCodigo,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBTIPOCTE.AsNoTracking()
            .FirstOrDefaultAsync(t => t.CiaCodigo == ciaCodigo && t.TclCodigo == tclCodigo, ct);
    }

    public async Task<TBTIPOCTE> CreateAsync(TBTIPOCTE entity, CancellationToken ct = default)
    {
        await _context.TBTIPOCTE.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Tipo cliente creado: Compania={Compania}, Codigo={Codigo}",
            entity.CiaCodigo,
            entity.TclCodigo
        );
        return entity;
    }

    public async Task<TBTIPOCTE> UpdateAsync(TBTIPOCTE entity, CancellationToken ct = default)
    {
        _context.TBTIPOCTE.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Tipo cliente actualizado: Compania={Compania}, Codigo={Codigo}",
            entity.CiaCodigo,
            entity.TclCodigo
        );
        return entity;
    }

    public async Task<bool> DeleteAsync(
        int ciaCodigo,
        int tclCodigo,
        CancellationToken ct = default
    )
    {
        var entity = await _context.TBTIPOCTE.FirstOrDefaultAsync(
            t => t.CiaCodigo == ciaCodigo && t.TclCodigo == tclCodigo,
            ct
        );

        if (entity == null)
            return false;

        _context.TBTIPOCTE.Remove(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Tipo cliente eliminado: Compania={Compania}, Codigo={Codigo}",
            ciaCodigo,
            tclCodigo
        );
        return true;
    }
}
