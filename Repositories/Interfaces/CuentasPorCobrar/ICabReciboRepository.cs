using ApiCm.Commons.Pagination;
using ApiCm.Entities.CuentasPorCobrar;

namespace ApiCm.Repositories.Interfaces.CuentasPorCobrar;

public interface ICabReciboRepository
{
    Task<(List<TBCABRECIBO> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBCABRECIBO?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        CancellationToken ct = default
    );
    Task<TBCABRECIBO> CreateAsync(TBCABRECIBO entity, CancellationToken ct = default);
    Task<TBCABRECIBO> UpdateAsync(TBCABRECIBO entity, CancellationToken ct = default);
}
