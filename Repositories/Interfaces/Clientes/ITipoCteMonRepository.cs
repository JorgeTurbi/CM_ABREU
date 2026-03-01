using ApiCm.Commons.Pagination;
using ApiCm.Entities.Clientes;

namespace ApiCm.Repositories.Interfaces.Clientes;

public interface ITipoCteMonRepository
{
    Task<(List<TBTIPOCTEMON> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBTIPOCTEMON?> GetByIdAsync(
        int ciaCodigo,
        int tclCodigo,
        int monCodigo,
        CancellationToken ct = default
    );
    Task<TBTIPOCTEMON> CreateAsync(TBTIPOCTEMON entity, CancellationToken ct = default);
    Task<TBTIPOCTEMON> UpdateAsync(TBTIPOCTEMON entity, CancellationToken ct = default);
}
