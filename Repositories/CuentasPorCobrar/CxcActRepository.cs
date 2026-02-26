using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.CuentasPorCobrar;

public class CxcActRepository : ICxcActRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<CxcActRepository> _logger;

    public CxcActRepository(CmAbreuDbContext context, ILogger<CxcActRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBCXCACT> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBCXCACT.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(c => c.CiaCodigo)
            .ThenBy(c => c.OfiCodigo)
            .ThenBy(c => c.MonCodigo)
            .ThenBy(c => c.CcaModulo)
            .ThenBy(c => c.CcaTipo)
            .ThenBy(c => c.CcaCodigo)
            .ThenBy(c => c.CcaAno)
            .ThenBy(c => c.CcaNumero)
            .ThenBy(c => c.CcaSecuencia)
            .ThenBy(c => c.CcaSubsec)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBCXCACT?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string ccaModulo,
        string ccaTipo,
        int ccaCodigo,
        string ccaAno,
        int ccaNumero,
        int ccaSecuencia,
        int ccaSubsec,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBCXCACT.AsNoTracking()
            .FirstOrDefaultAsync(
                c =>
                    c.CiaCodigo == ciaCodigo
                    && c.OfiCodigo == ofiCodigo
                    && c.MonCodigo == monCodigo
                    && c.CcaModulo == ccaModulo
                    && c.CcaTipo == ccaTipo
                    && c.CcaCodigo == ccaCodigo
                    && c.CcaAno == ccaAno
                    && c.CcaNumero == ccaNumero
                    && c.CcaSecuencia == ccaSecuencia
                    && c.CcaSubsec == ccaSubsec,
                ct
            );
    }

    public async Task<TBCXCACT> CreateAsync(TBCXCACT entity, CancellationToken ct = default)
    {
        await _context.TBCXCACT.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "CXC actual creado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Modulo={Modulo}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}, Secuencia={Secuencia}, Subsec={Subsec}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.CcaModulo,
            entity.CcaTipo,
            entity.CcaCodigo,
            entity.CcaAno,
            entity.CcaNumero,
            entity.CcaSecuencia,
            entity.CcaSubsec
        );
        return entity;
    }

    public async Task<TBCXCACT> UpdateAsync(TBCXCACT entity, CancellationToken ct = default)
    {
        _context.TBCXCACT.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "CXC actual actualizado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Modulo={Modulo}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}, Secuencia={Secuencia}, Subsec={Subsec}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.CcaModulo,
            entity.CcaTipo,
            entity.CcaCodigo,
            entity.CcaAno,
            entity.CcaNumero,
            entity.CcaSecuencia,
            entity.CcaSubsec
        );
        return entity;
    }

    public async Task<bool> DeleteAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string ccaModulo,
        string ccaTipo,
        int ccaCodigo,
        string ccaAno,
        int ccaNumero,
        int ccaSecuencia,
        int ccaSubsec,
        CancellationToken ct = default
    )
    {
        var entity = await _context.TBCXCACT.FirstOrDefaultAsync(
            c =>
                c.CiaCodigo == ciaCodigo
                && c.OfiCodigo == ofiCodigo
                && c.MonCodigo == monCodigo
                && c.CcaModulo == ccaModulo
                && c.CcaTipo == ccaTipo
                && c.CcaCodigo == ccaCodigo
                && c.CcaAno == ccaAno
                && c.CcaNumero == ccaNumero
                && c.CcaSecuencia == ccaSecuencia
                && c.CcaSubsec == ccaSubsec,
            ct
        );

        if (entity == null)
            return false;

        _context.TBCXCACT.Remove(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "CXC actual eliminado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Modulo={Modulo}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}, Secuencia={Secuencia}, Subsec={Subsec}",
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            ccaModulo,
            ccaTipo,
            ccaCodigo,
            ccaAno,
            ccaNumero,
            ccaSecuencia,
            ccaSubsec
        );
        return true;
    }
}
