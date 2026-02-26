using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using ApiCm.Services.Interfaces.Clientes;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.Clientes;

public class ContactoService : IContactoService
{
    private readonly IContactoRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<ContactoService> _logger;

    public ContactoService(
        IContactoRepository repository,
        IMapper mapper,
        ILogger<ContactoService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBCONTACTODto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBCONTACTODto>>(items);
            return new PagedResponse<List<TBCONTACTODto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener contactos");
            return new PagedResponse<List<TBCONTACTODto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCONTACTODto>> GetByIdAsync(int ciaCodigo, int conCodigo)
    {
        try
        {
            var entity = await _repository.GetByIdAsync(ciaCodigo, conCodigo);
            if (entity == null)
                return new ApiResponse<TBCONTACTODto>(false, "Contacto no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBCONTACTODto>(entity);
            return new ApiResponse<TBCONTACTODto>(true, "Contacto obtenido exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error al obtener contacto {Compania}/{Codigo}",
                ciaCodigo,
                conCodigo
            );
            return new ApiResponse<TBCONTACTODto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCONTACTODto>> CreateAsync(TBCONTACTODto dto)
    {
        try
        {
            var entity = _mapper.Map<TBCONTACTO>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBCONTACTODto>(created);
            return new ApiResponse<TBCONTACTODto>(true, "Contacto creado exitosamente", resultDto)
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear contacto");
            return new ApiResponse<TBCONTACTODto>(
                false,
                "Error al crear: registro duplicado o restricción de integridad violada"
            )
            {
                StatusCode = 400,
                Errors = [ex.InnerException?.Message ?? ex.Message],
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al crear contacto");
            return new ApiResponse<TBCONTACTODto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCONTACTODto>> UpdateAsync(
        int ciaCodigo,
        int conCodigo,
        TBCONTACTODto dto
    )
    {
        try
        {
            var existing = await _repository.GetByIdAsync(ciaCodigo, conCodigo);
            if (existing == null)
                return new ApiResponse<TBCONTACTODto>(false, "Contacto no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.ConCodigo = conCodigo;
            var entity = _mapper.Map<TBCONTACTO>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBCONTACTODto>(updated);
            return new ApiResponse<TBCONTACTODto>(
                true,
                "Contacto actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar contacto");
            return new ApiResponse<TBCONTACTODto>(
                false,
                "Error al actualizar: restricción de integridad violada"
            )
            {
                StatusCode = 400,
                Errors = [ex.InnerException?.Message ?? ex.Message],
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error al actualizar contacto {Compania}/{Codigo}",
                ciaCodigo,
                conCodigo
            );
            return new ApiResponse<TBCONTACTODto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<bool>> DeleteAsync(int ciaCodigo, int conCodigo)
    {
        try
        {
            var deleted = await _repository.DeleteAsync(ciaCodigo, conCodigo);
            if (!deleted)
                return new ApiResponse<bool>(false, "Contacto no encontrado") { StatusCode = 404 };

            return new ApiResponse<bool>(true, "Contacto eliminado exitosamente", true)
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(
                ex,
                "Error de BD al eliminar contacto {Compania}/{Codigo}",
                ciaCodigo,
                conCodigo
            );
            return new ApiResponse<bool>(
                false,
                "No se puede eliminar: existen registros dependientes"
            )
            {
                StatusCode = 409,
                Errors = [ex.InnerException?.Message ?? ex.Message],
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error al eliminar contacto {Compania}/{Codigo}",
                ciaCodigo,
                conCodigo
            );
            return new ApiResponse<bool>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
