using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;

namespace ApiCm.Services.Interfaces.CuentasPorCobrar;

public interface ICxcHisService
{
    Task<PagedResponse<List<TBCXCHISDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBCXCHISDto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string cchModulo,
        string cchTipo,
        int cchCodigo,
        string cchAno,
        int cchNumero,
        int cchSecuencia,
        int cchSubsec
    );
    Task<ApiResponse<TBCXCHISDto>> CreateAsync(TBCXCHISDto dto);
    Task<ApiResponse<TBCXCHISDto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string cchModulo,
        string cchTipo,
        int cchCodigo,
        string cchAno,
        int cchNumero,
        int cchSecuencia,
        int cchSubsec,
        TBCXCHISDto dto
    );
    Task<ApiResponse<bool>> DeleteAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string cchModulo,
        string cchTipo,
        int cchCodigo,
        string cchAno,
        int cchNumero,
        int cchSecuencia,
        int cchSubsec
    );
}
