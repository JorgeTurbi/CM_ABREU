using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;

namespace ApiCm.Services.Interfaces.Clientes;

public interface ITipoCteService
{
    Task<PagedResponse<List<TBTIPOCTEDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBTIPOCTEDto>> GetByIdAsync(int ciaCodigo, int tclCodigo);
    Task<ApiResponse<TBTIPOCTEDto>> CreateAsync(TBTIPOCTEDto dto);
    Task<ApiResponse<TBTIPOCTEDto>> UpdateAsync(int ciaCodigo, int tclCodigo, TBTIPOCTEDto dto);
    Task<ApiResponse<bool>> DeleteAsync(int ciaCodigo, int tclCodigo);
}
