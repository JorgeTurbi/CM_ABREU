using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.CuentasPorCobrar;

public class DetMovCxcRepository : IDetMovCxcRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<DetMovCxcRepository> _logger;

    public DetMovCxcRepository(CmAbreuDbContext context, ILogger<DetMovCxcRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBDETMOVCXC> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBDETMOVCXC.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(d => d.CiaCodigo)
            .ThenBy(d => d.OfiCodigo)
            .ThenBy(d => d.MonCodigo)
            .ThenBy(d => d.TdcTipo)
            .ThenBy(d => d.TdcCodigo)
            .ThenBy(d => d.DxcAno)
            .ThenBy(d => d.CmcNumero)
            .ThenBy(d => d.DmcSecuencia)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBDETMOVCXC?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        int dmcSecuencia,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBDETMOVCXC.AsNoTracking()
            .FirstOrDefaultAsync(
                d =>
                    d.CiaCodigo == ciaCodigo
                    && d.OfiCodigo == ofiCodigo
                    && d.MonCodigo == monCodigo
                    && d.TdcTipo == tdcTipo
                    && d.TdcCodigo == tdcCodigo
                    && d.DxcAno == dxcAno
                    && d.CmcNumero == cmcNumero
                    && d.DmcSecuencia == dmcSecuencia,
                ct
            );
    }

    public async Task<TBDETMOVCXC> CreateAsync(TBDETMOVCXC entity, CancellationToken ct = default)
    {
        await _context.TBDETMOVCXC.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Detalle movimiento CXC creado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}, Secuencia={Secuencia}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo,
            entity.DxcAno,
            entity.CmcNumero,
            entity.DmcSecuencia
        );
        return entity;
    }

    public async Task<TBDETMOVCXC> UpdateAsync(TBDETMOVCXC entity, CancellationToken ct = default)
    {
        _context.TBDETMOVCXC.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Detalle movimiento CXC actualizado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}, Secuencia={Secuencia}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo,
            entity.DxcAno,
            entity.CmcNumero,
            entity.DmcSecuencia
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
        int cmcNumero,
        int dmcSecuencia,
        CancellationToken ct = default
    )
    {
        var entity = await _context.TBDETMOVCXC.FirstOrDefaultAsync(
            d =>
                d.CiaCodigo == ciaCodigo
                && d.OfiCodigo == ofiCodigo
                && d.MonCodigo == monCodigo
                && d.TdcTipo == tdcTipo
                && d.TdcCodigo == tdcCodigo
                && d.DxcAno == dxcAno
                && d.CmcNumero == cmcNumero
                && d.DmcSecuencia == dmcSecuencia,
            ct
        );

        if (entity == null)
            return false;

        _context.TBDETMOVCXC.Remove(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Detalle movimiento CXC eliminado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}, Secuencia={Secuencia}",
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            tdcTipo,
            tdcCodigo,
            dxcAno,
            cmcNumero,
            dmcSecuencia
        );
        return true;
    }
}
