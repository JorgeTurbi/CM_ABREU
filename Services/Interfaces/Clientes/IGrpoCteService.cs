using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;

namespace ApiCm.Services.Interfaces.Clientes;

public interface IGrpoCteService
{
    Task<PagedResponse<List<TBGRPOCTEDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBGRPOCTEDto>> GetByIdAsync(int ciaCodigo, int gctCodigo);
    Task<ApiResponse<TBGRPOCTEDto>> CreateAsync(TBGRPOCTEDto dto);
    Task<ApiResponse<TBGRPOCTEDto>> UpdateAsync(int ciaCodigo, int gctCodigo, TBGRPOCTEDto dto);
}
