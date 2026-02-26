using ApiCm.Commons.Pagination;
using ApiCm.Entities.Clientes;

namespace ApiCm.Repositories.Interfaces.Clientes;

public interface ICteDefectoRepository
{
    Task<(List<TBCTEDEFECTO> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBCTEDEFECTO?> GetByIdAsync(
        int ciaCodigo,
        string cdfLocalExterior,
        CancellationToken ct = default
    );
    Task<TBCTEDEFECTO> CreateAsync(TBCTEDEFECTO entity, CancellationToken ct = default);
    Task<TBCTEDEFECTO> UpdateAsync(TBCTEDEFECTO entity, CancellationToken ct = default);
    Task<bool> DeleteAsync(
        int ciaCodigo,
        string cdfLocalExterior,
        CancellationToken ct = default
    );
}
