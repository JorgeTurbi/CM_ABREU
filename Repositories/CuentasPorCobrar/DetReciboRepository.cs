using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.CuentasPorCobrar;

public class DetReciboRepository : IDetReciboRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<DetReciboRepository> _logger;

    public DetReciboRepository(CmAbreuDbContext context, ILogger<DetReciboRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBDETRECIBO> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBDETRECIBO.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(d => d.CiaCodigo)
            .ThenBy(d => d.OfiCodigo)
            .ThenBy(d => d.MonCodigo)
            .ThenBy(d => d.TdcTipo)
            .ThenBy(d => d.TdcCodigo)
            .ThenBy(d => d.DxcAno)
            .ThenBy(d => d.CrcNumero)
            .ThenBy(d => d.DrcSecuencia)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBDETRECIBO?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        int drcSecuencia,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBDETRECIBO.AsNoTracking()
            .FirstOrDefaultAsync(
                d =>
                    d.CiaCodigo == ciaCodigo
                    && d.OfiCodigo == ofiCodigo
                    && d.MonCodigo == monCodigo
                    && d.TdcTipo == tdcTipo
                    && d.TdcCodigo == tdcCodigo
                    && d.DxcAno == dxcAno
                    && d.CrcNumero == crcNumero
                    && d.DrcSecuencia == drcSecuencia,
                ct
            );
    }

    public async Task<TBDETRECIBO> CreateAsync(TBDETRECIBO entity, CancellationToken ct = default)
    {
        await _context.TBDETRECIBO.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Detalle recibo creado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}, Secuencia={Secuencia}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo,
            entity.DxcAno,
            entity.CrcNumero,
            entity.DrcSecuencia
        );
        return entity;
    }

    public async Task<TBDETRECIBO> UpdateAsync(TBDETRECIBO entity, CancellationToken ct = default)
    {
        _context.TBDETRECIBO.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Detalle recibo actualizado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}, Secuencia={Secuencia}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo,
            entity.DxcAno,
            entity.CrcNumero,
            entity.DrcSecuencia
        );
        return entity;
    }

    public async Task<bool> DeleteAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        int drcSecuencia,
        CancellationToken ct = default
    )
    {
        var entity = await _context.TBDETRECIBO.FirstOrDefaultAsync(
            d =>
                d.CiaCodigo == ciaCodigo
                && d.OfiCodigo == ofiCodigo
                && d.MonCodigo == monCodigo
                && d.TdcTipo == tdcTipo
                && d.TdcCodigo == tdcCodigo
                && d.DxcAno == dxcAno
                && d.CrcNumero == crcNumero
                && d.DrcSecuencia == drcSecuencia,
            ct
        );

        if (entity == null)
            return false;

        _context.TBDETRECIBO.Remove(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Detalle recibo eliminado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}, Secuencia={Secuencia}",
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            tdcTipo,
            tdcCodigo,
            dxcAno,
            crcNumero,
            drcSecuencia
        );
        return true;
    }
}
