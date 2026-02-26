using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.CuentasPorCobrar;

public class DoctoCxcRepository : IDoctoCxcRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<DoctoCxcRepository> _logger;

    public DoctoCxcRepository(CmAbreuDbContext context, ILogger<DoctoCxcRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBDOCTOCXC> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBDOCTOCXC.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(d => d.CiaCodigo)
            .ThenBy(d => d.OfiCodigo)
            .ThenBy(d => d.MonCodigo)
            .ThenBy(d => d.TdcTipo)
            .ThenBy(d => d.TdcCodigo)
            .ThenBy(d => d.DxcAno)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBDOCTOCXC?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBDOCTOCXC.AsNoTracking()
            .FirstOrDefaultAsync(
                d =>
                    d.CiaCodigo == ciaCodigo
                    && d.OfiCodigo == ofiCodigo
                    && d.MonCodigo == monCodigo
                    && d.TdcTipo == tdcTipo
                    && d.TdcCodigo == tdcCodigo
                    && d.DxcAno == dxcAno,
                ct
            );
    }

    public async Task<TBDOCTOCXC> CreateAsync(TBDOCTOCXC entity, CancellationToken ct = default)
    {
        await _context.TBDOCTOCXC.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Documento CXC creado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo,
            entity.DxcAno
        );
        return entity;
    }

    public async Task<TBDOCTOCXC> UpdateAsync(TBDOCTOCXC entity, CancellationToken ct = default)
    {
        _context.TBDOCTOCXC.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Documento CXC actualizado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.TdcTipo,
            entity.TdcCodigo,
            entity.DxcAno
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
        CancellationToken ct = default
    )
    {
        var entity = await _context.TBDOCTOCXC.FirstOrDefaultAsync(
            d =>
                d.CiaCodigo == ciaCodigo
                && d.OfiCodigo == ofiCodigo
                && d.MonCodigo == monCodigo
                && d.TdcTipo == tdcTipo
                && d.TdcCodigo == tdcCodigo
                && d.DxcAno == dxcAno,
            ct
        );

        if (entity == null)
            return false;

        _context.TBDOCTOCXC.Remove(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Documento CXC eliminado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}",
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            tdcTipo,
            tdcCodigo,
            dxcAno
        );
        return true;
    }
}
