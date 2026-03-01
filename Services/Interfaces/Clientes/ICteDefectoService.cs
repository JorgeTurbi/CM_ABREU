using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;

namespace ApiCm.Services.Interfaces.Clientes;

public interface ICteDefectoService
{
    Task<PagedResponse<List<TBCTEDEFECTODto>>> GetAllAsync(PaginationRequest pagination);
    Task<ApiResponse<TBCTEDEFECTODto>> GetByIdAsync(int ciaCodigo, string cdfLocalExterior);
    Task<ApiResponse<TBCTEDEFECTODto>> CreateAsync(TBCTEDEFECTODto dto);
    Task<ApiResponse<TBCTEDEFECTODto>> UpdateAsync(
        int ciaCodigo,
        string cdfLocalExterior,
        TBCTEDEFECTODto dto
    );
}
