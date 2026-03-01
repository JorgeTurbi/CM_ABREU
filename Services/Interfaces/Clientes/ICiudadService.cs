using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;

namespace ApiCm.Services.Interfaces.Clientes;

public interface ICiudadService
{
    Task<PagedResponse<List<TBCIUDADDto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBCIUDADDto>> GetByIdAsync(int cdaCodigo);
    Task<ApiResponse<TBCIUDADDto>> CreateAsync(TBCIUDADDto dto);
    Task<ApiResponse<TBCIUDADDto>> UpdateAsync(int cdaCodigo, TBCIUDADDto dto);
}
