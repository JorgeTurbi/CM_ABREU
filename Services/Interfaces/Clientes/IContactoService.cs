using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;

namespace ApiCm.Services.Interfaces.Clientes;

public interface IContactoService
{
    Task<PagedResponse<List<TBCONTACTODto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBCONTACTODto>> GetByIdAsync(int ciaCodigo, int conCodigo);
    Task<ApiResponse<TBCONTACTODto>> CreateAsync(TBCONTACTODto dto);
    Task<ApiResponse<TBCONTACTODto>> UpdateAsync(int ciaCodigo, int conCodigo, TBCONTACTODto dto);
    Task<ApiResponse<bool>> DeleteAsync(int ciaCodigo, int conCodigo);
}
