using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.CuentasPorCobrar;

public class CabMovCxcRepository : ICabMovCxcRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<CabMovCxcRepository> _logger;

    public CabMovCxcRepository(CmAbreuDbContext context, ILogger<CabMovCxcRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBCABMOVCXC> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBCABMOVCXC.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(c => c.CiaCodigo)
            .ThenBy(c => c.OfiCodigo)
            .ThenBy(c => c.MonCodigo)
            .ThenBy(c => c.TdcTipo)
            .ThenBy(c => c.TdcCodigo)
            .ThenBy(c => c.DxcAno)
            .ThenBy(c => c.CmcNumero)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBCABMOVCXC?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBCABMOVCXC.AsNoTracking()
            .FirstOrDefaultAsync(
                c =>
                    c.CiaCodigo == ciaCodigo
                    && c.OfiCodigo == ofiCodigo
                    && c.MonCodigo == monCodigo
                    && c.TdcTipo == tdcTipo
                    && c.TdcCodigo == tdcCodigo
                    && c.DxcAno == dxcAno
                    && c.CmcNumero == cmcNumero,
                ct
            );
    }

    public async Task<TBCABMOVCXC> CreateAsync(TBCABMOVCXC entity, CancellationToken ct = default)
    {
        await _context.TBCABMOVCXC.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Movimiento CXC creado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo,
            entity.DxcAno,
            entity.CmcNumero
        );
        return entity;
    }

    public async Task<TBCABMOVCXC> UpdateAsync(TBCABMOVCXC entity, CancellationToken ct = default)
    {
        _context.TBCABMOVCXC.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Movimiento CXC actualizado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo,
            entity.DxcAno,
            entity.CmcNumero
        );
        return entity;
    }
}
