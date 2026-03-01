using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;

namespace ApiCm.Services.Interfaces.CuentasPorCobrar;

public interface ICabReciboService
{
    Task<PagedResponse<List<TBCABRECIBODto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBCABRECIBODto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero
    );
    Task<ApiResponse<TBCABRECIBODto>> CreateAsync(TBCABRECIBODto dto);
    Task<ApiResponse<TBCABRECIBODto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        TBCABRECIBODto dto
    );
}
