using ApiCm.Commons.Pagination;
using ApiCm.Entities.CuentasPorCobrar;

namespace ApiCm.Repositories.Interfaces.CuentasPorCobrar;

public interface ITipoDocCxcRepository
{
    Task<(List<TBTIPODOCCXC> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBTIPODOCCXC?> GetByIdAsync(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        CancellationToken ct = default
    );
    Task<TBTIPODOCCXC> CreateAsync(TBTIPODOCCXC entity, CancellationToken ct = default);
    Task<TBTIPODOCCXC> UpdateAsync(TBTIPODOCCXC entity, CancellationToken ct = default);
    Task<bool> DeleteAsync(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        CancellationToken ct = default
    );
}
