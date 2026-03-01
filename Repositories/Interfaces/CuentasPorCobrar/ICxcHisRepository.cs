using ApiCm.Commons.Pagination;
using ApiCm.Entities.CuentasPorCobrar;

namespace ApiCm.Repositories.Interfaces.CuentasPorCobrar;

public interface ICxcHisRepository
{
    Task<(List<TBCXCHIS> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBCXCHIS?> GetByIdAsync(
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
    );
    Task<TBCXCHIS> CreateAsync(TBCXCHIS entity, CancellationToken ct = default);
    Task<TBCXCHIS> UpdateAsync(TBCXCHIS entity, CancellationToken ct = default);
}
