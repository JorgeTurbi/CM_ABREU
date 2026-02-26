using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;

namespace ApiCm.Services.Interfaces.CuentasPorCobrar;

public interface IDetMovCxcService
{
    Task<PagedResponse<List<TBDETMOVCXCDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBDETMOVCXCDto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        int dmcSecuencia
    );
    Task<ApiResponse<TBDETMOVCXCDto>> CreateAsync(TBDETMOVCXCDto dto);
    Task<ApiResponse<TBDETMOVCXCDto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        int dmcSecuencia,
        TBDETMOVCXCDto dto
    );
    Task<ApiResponse<bool>> DeleteAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        int dmcSecuencia
    );
}
