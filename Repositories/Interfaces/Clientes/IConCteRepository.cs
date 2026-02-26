using ApiCm.Commons.Pagination;
using ApiCm.Entities.Clientes;

namespace ApiCm.Repositories.Interfaces.Clientes;

public interface IConCteRepository
{
    Task<(List<TBCONCTE> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBCONCTE?> GetByIdAsync(
        int ciaCodigo,
        string cteCodigo,
        int cclCodigo,
        CancellationToken ct = default
    );
    Task<TBCONCTE> CreateAsync(TBCONCTE entity, CancellationToken ct = default);
    Task<TBCONCTE> UpdateAsync(TBCONCTE entity, CancellationToken ct = default);
    Task<bool> DeleteAsync(
        int ciaCodigo,
        string cteCodigo,
        int cclCodigo,
        CancellationToken ct = default
    );
}
