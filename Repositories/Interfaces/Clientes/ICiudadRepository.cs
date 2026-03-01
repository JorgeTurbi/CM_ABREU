using ApiCm.Commons.Pagination;
using ApiCm.Entities.Clientes;

namespace ApiCm.Repositories.Interfaces.Clientes;

public interface ICiudadRepository
{
    Task<(List<TBCIUDAD> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBCIUDAD?> GetByIdAsync(int cdaCodigo, CancellationToken ct = default);
    Task<TBCIUDAD> CreateAsync(TBCIUDAD entity, CancellationToken ct = default);
    Task<TBCIUDAD> UpdateAsync(TBCIUDAD entity, CancellationToken ct = default);
}
