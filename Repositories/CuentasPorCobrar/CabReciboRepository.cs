using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.CuentasPorCobrar;

public class CabReciboRepository : ICabReciboRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<CabReciboRepository> _logger;

    public CabReciboRepository(CmAbreuDbContext context, ILogger<CabReciboRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBCABRECIBO> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBCABRECIBO.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(c => c.CiaCodigo)
            .ThenBy(c => c.OfiCodigo)
            .ThenBy(c => c.MonCodigo)
            .ThenBy(c => c.TdcTipo)
            .ThenBy(c => c.TdcCodigo)
            .ThenBy(c => c.DxcAno)
            .ThenBy(c => c.CrcNumero)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBCABRECIBO?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBCABRECIBO.AsNoTracking()
            .FirstOrDefaultAsync(
                c =>
                    c.CiaCodigo == ciaCodigo
                    && c.OfiCodigo == ofiCodigo
                    && c.MonCodigo == monCodigo
                    && c.TdcTipo == tdcTipo
                    && c.TdcCodigo == tdcCodigo
                    && c.DxcAno == dxcAno
                    && c.CrcNumero == crcNumero,
                ct
            );
    }

    public async Task<TBCABRECIBO> CreateAsync(TBCABRECIBO entity, CancellationToken ct = default)
    {
        await _context.TBCABRECIBO.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Recibo creado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo,
            entity.DxcAno,
            entity.CrcNumero
        );
        return entity;
    }

    public async Task<TBCABRECIBO> UpdateAsync(TBCABRECIBO entity, CancellationToken ct = default)
    {
        _context.TBCABRECIBO.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Recibo actualizado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo,
            entity.DxcAno,
            entity.CrcNumero
        );
        return entity;
    }
}
