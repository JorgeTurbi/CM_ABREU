using ApiCm.Commons.Pagination;
using ApiCm.Entities.Clientes;

namespace ApiCm.Repositories.Interfaces.Clientes;

public interface IContactoRepository
{
    Task<(List<TBCONTACTO> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBCONTACTO?> GetByIdAsync(int ciaCodigo, int conCodigo, CancellationToken ct = default);
    Task<TBCONTACTO> CreateAsync(TBCONTACTO entity, CancellationToken ct = default);
    Task<TBCONTACTO> UpdateAsync(TBCONTACTO entity, CancellationToken ct = default);
}
