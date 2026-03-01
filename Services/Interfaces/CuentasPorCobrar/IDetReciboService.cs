using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;

namespace ApiCm.Services.Interfaces.CuentasPorCobrar;

public interface IDetReciboService
{
    Task<PagedResponse<List<TBDETRECIBODto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBDETRECIBODto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        int drcSecuencia
    );
    Task<ApiResponse<TBDETRECIBODto>> CreateAsync(TBDETRECIBODto dto);
    Task<ApiResponse<TBDETRECIBODto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        int drcSecuencia,
        TBDETRECIBODto dto
    );
}
