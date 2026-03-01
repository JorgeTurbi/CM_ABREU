using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.CuentasPorCobrar;

public class CxcHisRepository : ICxcHisRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<CxcHisRepository> _logger;

    public CxcHisRepository(CmAbreuDbContext context, ILogger<CxcHisRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBCXCHIS> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBCXCHIS.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(c => c.CiaCodigo)
            .ThenBy(c => c.OfiCodigo)
            .ThenBy(c => c.MonCodigo)
            .ThenBy(c => c.CchModulo)
            .ThenBy(c => c.CchTipo)
            .ThenBy(c => c.CchCodigo)
            .ThenBy(c => c.CchAno)
            .ThenBy(c => c.CchNumero)
            .ThenBy(c => c.CchSecuencia)
            .ThenBy(c => c.CchSubsec)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBCXCHIS?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string cchModulo,
        string cchTipo,
        int cchCodigo,
        string cchAno,
        int cchNumero,
        int cchSecuencia,
        int cchSubsec,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBCXCHIS.AsNoTracking()
            .FirstOrDefaultAsync(
                c =>
                    c.CiaCodigo == ciaCodigo
                    && c.OfiCodigo == ofiCodigo
                    && c.MonCodigo == monCodigo
                    && c.CchModulo == cchModulo
                    && c.CchTipo == cchTipo
                    && c.CchCodigo == cchCodigo
                    && c.CchAno == cchAno
                    && c.CchNumero == cchNumero
                    && c.CchSecuencia == cchSecuencia
                    && c.CchSubsec == cchSubsec,
                ct
            );
    }

    public async Task<TBCXCHIS> CreateAsync(TBCXCHIS entity, CancellationToken ct = default)
    {
        await _context.TBCXCHIS.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "CXC historico creado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Modulo={Modulo}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}, Secuencia={Secuencia}, Subsec={Subsec}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.CchModulo,
            entity.CchTipo,
            entity.CchCodigo,
            entity.CchAno,
            entity.CchNumero,
            entity.CchSecuencia,
            entity.CchSubsec
        );
        return entity;
    }

    public async Task<TBCXCHIS> UpdateAsync(TBCXCHIS entity, CancellationToken ct = default)
    {
        _context.TBCXCHIS.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "CXC historico actualizado: Compania={Compania}, Oficina={Oficina}, Moneda={Moneda}, Modulo={Modulo}, Tipo={Tipo}, Codigo={Codigo}, Ano={Ano}, Numero={Numero}, Secuencia={Secuencia}, Subsec={Subsec}",
            entity.CiaCodigo,
            entity.OfiCodigo,
            entity.MonCodigo,
            entity.CchModulo,
            entity.CchTipo,
            entity.CchCodigo,
            entity.CchAno,
            entity.CchNumero,
            entity.CchSecuencia,
            entity.CchSubsec
        );
        return entity;
    }
}
