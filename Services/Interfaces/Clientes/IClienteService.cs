using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;

namespace ApiCm.Services.Interfaces.Clientes;

public interface IClienteService
{
    Task<PagedResponse<List<TBCLIENTEDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBCLIENTEDto>> GetByIdAsync(int ciaCodigo, string cteCodigo);
    Task<ApiResponse<TBCLIENTEDto>> CreateAsync(TBCLIENTEDto dto);
    Task<ApiResponse<TBCLIENTEDto>> UpdateAsync(int ciaCodigo, string cteCodigo, TBCLIENTEDto dto);
    Task<ApiResponse<bool>> DeleteAsync(int ciaCodigo, string cteCodigo);
}
