using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;

namespace ApiCm.Services.Interfaces.CuentasPorCobrar;

public interface ICabMovCxcService
{
    Task<PagedResponse<List<TBCABMOVCXCDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBCABMOVCXCDto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero
    );
    Task<ApiResponse<TBCABMOVCXCDto>> CreateAsync(TBCABMOVCXCDto dto);
    Task<ApiResponse<TBCABMOVCXCDto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        TBCABMOVCXCDto dto
    );
}
