using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;

namespace ApiCm.Services.Interfaces.CuentasPorCobrar;

public interface ITipoDocCxcService
{
    Task<PagedResponse<List<TBTIPODOCCXCDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBTIPODOCCXCDto>> GetByIdAsync(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo
    );
    Task<ApiResponse<TBTIPODOCCXCDto>> CreateAsync(TBTIPODOCCXCDto dto);
    Task<ApiResponse<TBTIPODOCCXCDto>> UpdateAsync(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        TBTIPODOCCXCDto dto
    );
    Task<ApiResponse<bool>> DeleteAsync(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo
    );
}
