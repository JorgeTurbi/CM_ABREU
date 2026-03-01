using ApiCm.Commons.Pagination;
using ApiCm.Data;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Repositories.Clientes;

public class ContactoRepository : IContactoRepository
{
    private readonly CmAbreuDbContext _context;
    private readonly ILogger<ContactoRepository> _logger;

    public ContactoRepository(CmAbreuDbContext context, ILogger<ContactoRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(List<TBCONTACTO> Items, int TotalCount)> GetAllAsync(
        PaginationRequest pagination,
        CancellationToken ct = default
    )
    {
        var query = _context.TBCONTACTO.AsNoTracking();
        var totalCount = await query.CountAsync(ct);

        var items = await query
            .OrderBy(c => c.CiaCodigo)
            .ThenBy(c => c.ConCodigo)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync(ct);

        return (items, totalCount);
    }

    public async Task<TBCONTACTO?> GetByIdAsync(
        int ciaCodigo,
        int conCodigo,
        CancellationToken ct = default
    )
    {
        return await _context
            .TBCONTACTO.AsNoTracking()
            .FirstOrDefaultAsync(c => c.CiaCodigo == ciaCodigo && c.ConCodigo == conCodigo, ct);
    }

    public async Task<TBCONTACTO> CreateAsync(TBCONTACTO entity, CancellationToken ct = default)
    {
        await _context.TBCONTACTO.AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Contacto creado: Compania={Compania}, Codigo={Codigo}, Nombre={Nombre}",
            entity.CiaCodigo,
            entity.ConCodigo,
            entity.ConNombre
        );
        return entity;
    }

    public async Task<TBCONTACTO> UpdateAsync(TBCONTACTO entity, CancellationToken ct = default)
    {
        _context.TBCONTACTO.Update(entity);
        await _context.SaveChangesAsync(ct);
        _logger.LogInformation(
            "Contacto actualizado: Compania={Compania}, Codigo={Codigo}",
            entity.CiaCodigo,
            entity.ConCodigo
        );
        return entity;
    }
}
