using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;

namespace ApiCm.Services.Interfaces.CuentasPorCobrar;

public interface ICxcActService
{
    Task<PagedResponse<List<TBCXCACTDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBCXCACTDto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string ccaModulo,
        string ccaTipo,
        int ccaCodigo,
        string ccaAno,
        int ccaNumero,
        int ccaSecuencia,
        int ccaSubsec
    );
    Task<ApiResponse<TBCXCACTDto>> CreateAsync(TBCXCACTDto dto);
    Task<ApiResponse<TBCXCACTDto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string ccaModulo,
        string ccaTipo,
        int ccaCodigo,
        string ccaAno,
        int ccaNumero,
        int ccaSecuencia,
        int ccaSubsec,
        TBCXCACTDto dto
    );
    Task<ApiResponse<bool>> DeleteAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string ccaModulo,
        string ccaTipo,
        int ccaCodigo,
        string ccaAno,
        int ccaNumero,
        int ccaSecuencia,
        int ccaSubsec
    );
}
