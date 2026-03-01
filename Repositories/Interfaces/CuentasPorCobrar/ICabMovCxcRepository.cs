using ApiCm.Commons.Pagination;
using ApiCm.Entities.CuentasPorCobrar;

namespace ApiCm.Repositories.Interfaces.CuentasPorCobrar;

public interface ICabMovCxcRepository
{
    Task<(List<TBCABMOVCXC> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBCABMOVCXC?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        CancellationToken ct = default
    );
    Task<TBCABMOVCXC> CreateAsync(TBCABMOVCXC entity, CancellationToken ct = default);
    Task<TBCABMOVCXC> UpdateAsync(TBCABMOVCXC entity, CancellationToken ct = default);
}
