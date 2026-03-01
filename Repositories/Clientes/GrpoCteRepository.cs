using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.Clientes;

public class GrpoCteRepository : IGrpoCteRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<GrpoCteRepository> _logger;

    public GrpoCteRepository(CmAbreuDbContext context, ILogger<GrpoCteRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBGRPOCTE> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBGRPOCTE.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(g => g.CiaCodigo)
            .ThenBy(g => g.GctCodigo)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBGRPOCTE?> GetByIdAsync(
        int ciaCodigo,
        int gctCodigo,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBGRPOCTE.AsNoTracking()
            .FirstOrDefaultAsync(g => g.CiaCodigo == ciaCodigo && g.GctCodigo == gctCodigo, ct);
    }

    public async Task<TBGRPOCTE> CreateAsync(TBGRPOCTE entity, CancellationToken ct = default)
    {
        await _context.TBGRPOCTE.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Grupo cliente creado: Compania={Compania}, Codigo={Codigo}",
            entity.CiaCodigo,
            entity.GctCodigo
        );
        return entity;
    }

    public async Task<TBGRPOCTE> UpdateAsync(TBGRPOCTE entity, CancellationToken ct = default)
    {
        _context.TBGRPOCTE.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Grupo cliente actualizado: Compania={Compania}, Codigo={Codigo}",
            entity.CiaCodigo,
            entity.GctCodigo
        );
        return entity;
    }
}
