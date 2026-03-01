using ApiCm.Commons.Pagination;
using ApiCm.Entities.CuentasPorCobrar;

namespace ApiCm.Repositories.Interfaces.CuentasPorCobrar;

public interface IDoctoCxcRepository
{
    Task<(List<TBDOCTOCXC> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBDOCTOCXC?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        CancellationToken ct = default
    );
    Task<TBDOCTOCXC> CreateAsync(TBDOCTOCXC entity, CancellationToken ct = default);
    Task<TBDOCTOCXC> UpdateAsync(TBDOCTOCXC entity, CancellationToken ct = default);
}
