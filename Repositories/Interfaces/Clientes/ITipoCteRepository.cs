using ApiCm.Commons.Pagination;
using ApiCm.Entities.Clientes;

namespace ApiCm.Repositories.Interfaces.Clientes;

public interface ITipoCteRepository
{
    Task<(List<TBTIPOCTE> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBTIPOCTE?> GetByIdAsync(int ciaCodigo, int tclCodigo, CancellationToken ct = default);
    Task<TBTIPOCTE> CreateAsync(TBTIPOCTE entity, CancellationToken ct = default);
    Task<TBTIPOCTE> UpdateAsync(TBTIPOCTE entity, CancellationToken ct = default);
    Task<bool> DeleteAsync(int ciaCodigo, int tclCodigo, CancellationToken ct = default);
}
