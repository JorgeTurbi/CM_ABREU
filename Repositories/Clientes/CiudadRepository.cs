using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.Clientes;

public class CiudadRepository : ICiudadRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<CiudadRepository> _logger;

    public CiudadRepository(CmAbreuDbContext context, ILogger<CiudadRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBCIUDAD> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBCIUDAD.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(c => c.CdaCodigo)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBCIUDAD?> GetByIdAsync(int cdaCodigo, CancellationToken ct = default)
    {
        return await _context
            .TBCIUDAD.AsNoTracking()
            .FirstOrDefaultAsync(c => c.CdaCodigo == cdaCodigo, ct);
    }

    public async Task<TBCIUDAD> CreateAsync(TBCIUDAD entity, CancellationToken ct = default)
    {
        await _context.TBCIUDAD.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation("Ciudad creada: Codigo={Codigo}", entity.CdaCodigo);
        return entity;
    }

    public async Task<TBCIUDAD> UpdateAsync(TBCIUDAD entity, CancellationToken ct = default)
    {
        _context.TBCIUDAD.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation("Ciudad actualizada: Codigo={Codigo}", entity.CdaCodigo);
        return entity;
    }
}
