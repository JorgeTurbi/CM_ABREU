using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;

namespace ApiCm.Services.Interfaces.Clientes;

public interface IConCteService
{
    Task<PagedResponse<List<TBCONCTEDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBCONCTEDto>> GetByIdAsync(int ciaCodigo, string cteCodigo, int cclCodigo);
    Task<ApiResponse<TBCONCTEDto>> CreateAsync(TBCONCTEDto dto);
    Task<ApiResponse<TBCONCTEDto>> UpdateAsync(
        int ciaCodigo,
        string cteCodigo,
        int cclCodigo,
        TBCONCTEDto dto
    );
}
