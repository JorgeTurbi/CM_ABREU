using ApiCm.Commons.Pagination;
using ApiCm.Entities.CuentasPorCobrar;

namespace ApiCm.Repositories.Interfaces.CuentasPorCobrar;

public interface IDetMovCxcRepository
{
    Task<(List<TBDETMOVCXC> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBDETMOVCXC?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        int dmcSecuencia,
        CancellationToken ct = default
    );
    Task<TBDETMOVCXC> CreateAsync(TBDETMOVCXC entity, CancellationToken ct = default);
    Task<TBDETMOVCXC> UpdateAsync(TBDETMOVCXC entity, CancellationToken ct = default);
    Task<bool> DeleteAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        int dmcSecuencia,
        CancellationToken ct = default
    );
}
