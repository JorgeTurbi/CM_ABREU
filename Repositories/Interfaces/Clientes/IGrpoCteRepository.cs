using ApiCm.Commons.Pagination;
using ApiCm.Entities.Clientes;

namespace ApiCm.Repositories.Interfaces.Clientes;

public interface IGrpoCteRepository
{
    Task<(List<TBGRPOCTE> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBGRPOCTE?> GetByIdAsync(int ciaCodigo, int gctCodigo, CancellationToken ct = default);
    Task<TBGRPOCTE> CreateAsync(TBGRPOCTE entity, CancellationToken ct = default);
    Task<TBGRPOCTE> UpdateAsync(TBGRPOCTE entity, CancellationToken ct = default);
    Task<bool> DeleteAsync(int ciaCodigo, int gctCodigo, CancellationToken ct = default);
}
