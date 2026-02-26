using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;

namespace ApiCm.Services.Interfaces.Clientes;

public interface ITipoCteMonService
{
    Task<PagedResponse<List<TBTIPOCTEMONDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBTIPOCTEMONDto>> GetByIdAsync(int ciaCodigo, int tclCodigo, int monCodigo);
    Task<ApiResponse<TBTIPOCTEMONDto>> CreateAsync(TBTIPOCTEMONDto dto);
    Task<ApiResponse<TBTIPOCTEMONDto>> UpdateAsync(
        int ciaCodigo,
        int tclCodigo,
        int monCodigo,
        TBTIPOCTEMONDto dto
    );
    Task<ApiResponse<bool>> DeleteAsync(int ciaCodigo, int tclCodigo, int monCodigo);
}
