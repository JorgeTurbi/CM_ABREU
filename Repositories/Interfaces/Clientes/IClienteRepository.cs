using ApiCm.Commons.Pagination;
using ApiCm.Entities.Clientes;

namespace ApiCm.Repositories.Interfaces.Clientes;

public interface IClienteRepository
{
    Task<(List<TBCLIENTE> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    );
    Task<TBCLIENTE?> GetByIdAsync(int ciaCodigo, string cteCodigo, CancellationToken ct = default);
    Task<TBCLIENTE> CreateAsync(TBCLIENTE entity, CancellationToken ct = default);
    Task<TBCLIENTE> UpdateAsync(TBCLIENTE entity, CancellationToken ct = default);
}
