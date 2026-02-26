using ApiCm.Commons.Pagination;
using ApiCm.Entities.CuentasPorCobrar;

namespace ApiCm.Repositories.Interfaces.CuentasPorCobrar;

public interface IDetReciboRepository
{
    Task<(List<TBDETRECIBO> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBDETRECIBO?> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        int drcSecuencia,
        CancellationToken ct = default
    );
    Task<TBDETRECIBO> CreateAsync(TBDETRECIBO entity, CancellationToken ct = default);
    Task<TBDETRECIBO> UpdateAsync(TBDETRECIBO entity, CancellationToken ct = default);
    Task<bool> DeleteAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        int drcSecuencia,
        CancellationToken ct = default
    );
}
