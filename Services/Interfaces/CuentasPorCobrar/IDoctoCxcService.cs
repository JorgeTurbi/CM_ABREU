using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;

namespace ApiCm.Services.Interfaces.CuentasPorCobrar;

public interface IDoctoCxcService
{
    Task<PagedResponse<List<TBDOCTOCXCDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBDOCTOCXCDto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno
    );
    Task<ApiResponse<TBDOCTOCXCDto>> CreateAsync(TBDOCTOCXCDto dto);
    Task<ApiResponse<TBDOCTOCXCDto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        TBDOCTOCXCDto dto
    );
}
