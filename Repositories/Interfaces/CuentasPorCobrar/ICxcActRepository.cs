using ApiCm.Commons.Pagination;
using ApiCm.Entities.CuentasPorCobrar;

namespace ApiCm.Repositories.Interfaces.CuentasPorCobrar;

public interface ICxcActRepository
{
    Task<(List<TBCXCACT> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBCXCACT?> GetByIdAsync(
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
    );
    Task<TBCXCACT> CreateAsync(TBCXCACT entity, CancellationToken ct = default);
    Task<TBCXCACT> UpdateAsync(TBCXCACT entity, CancellationToken ct = default);
    Task<bool> DeleteAsync(
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
    );
}
