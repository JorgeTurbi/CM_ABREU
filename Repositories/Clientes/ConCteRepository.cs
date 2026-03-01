using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.Clientes;

public class ConCteRepository : IConCteRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<ConCteRepository> _logger;

    public ConCteRepository(CmAbreuDbContext context, ILogger<ConCteRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBCONCTE> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBCONCTE.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(c => c.CiaCodigo)
            .ThenBy(c => c.CteCodigo)
            .ThenBy(c => c.CclCodigo)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBCONCTE?> GetByIdAsync(
        int ciaCodigo,
        string cteCodigo,
        int cclCodigo,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBCONCTE.AsNoTracking()
            .FirstOrDefaultAsync(
                c =>
                    c.CiaCodigo == ciaCodigo
                    && c.CteCodigo == cteCodigo
                    && c.CclCodigo == cclCodigo,
                ct
            );
    }

    public async Task<TBCONCTE> CreateAsync(TBCONCTE entity, CancellationToken ct = default)
    {
        await _context.TBCONCTE.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Contacto-Cliente creado: Compania={Compania}, Cliente={Cliente}, Contacto={Contacto}",
            entity.CiaCodigo,
            entity.CteCodigo,
            entity.CclCodigo
        );
        return entity;
    }

    public async Task<TBCONCTE> UpdateAsync(TBCONCTE entity, CancellationToken ct = default)
    {
        _context.TBCONCTE.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Contacto-Cliente actualizado: Compania={Compania}, Cliente={Cliente}, Contacto={Contacto}",
            entity.CiaCodigo,
            entity.CteCodigo,
            entity.CclCodigo
        );
        return entity;
    }
}
