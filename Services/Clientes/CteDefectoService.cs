using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using ApiCm.Services.Interfaces.Clientes;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.Clientes;

public class CteDefectoService : ICteDefectoService
{
    private readonly ICteDefectoRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<CteDefectoService> _logger;

    public CteDefectoService(
        ICteDefectoRepository repository,
        IMapper mapper,
        ILogger<CteDefectoService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBCTEDEFECTODto>>> GetAllAsync(
        PaginationRequest pagination
    )
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBCTEDEFECTODto>>(items);
            return new PagedResponse<List<TBCTEDEFECTODto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener defaults de cliente");
            return new PagedResponse<List<TBCTEDEFECTODto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCTEDEFECTODto>> GetByIdAsync(
        int ciaCodigo,
        string cdfLocalExterior
    )
    {
        try
        {
            var entity = await _repository.GetByIdAsync(ciaCodigo, cdfLocalExterior);
            if (entity == null)
                return new ApiResponse<TBCTEDEFECTODto>(false, "Default de cliente no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBCTEDEFECTODto>(entity);
            return new ApiResponse<TBCTEDEFECTODto>(true, "Registro obtenido exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener default de cliente");
            return new ApiResponse<TBCTEDEFECTODto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCTEDEFECTODto>> CreateAsync(TBCTEDEFECTODto dto)
    {
        try
        {
            var entity = _mapper.Map<TBCTEDEFECTO>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBCTEDEFECTODto>(created);
            return new ApiResponse<TBCTEDEFECTODto>(
                true,
                "Default de cliente creado exitosamente",
                resultDto
            )
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear default de cliente");
            return new ApiResponse<TBCTEDEFECTODto>(
                false,
                "Error al crear: verifique FKs o registro duplicado"
            )
            {
                StatusCode = 400,
                Errors = [ex.InnerException?.Message ?? ex.Message],
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al crear default de cliente");
            return new ApiResponse<TBCTEDEFECTODto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCTEDEFECTODto>> UpdateAsync(
        int ciaCodigo,
        string cdfLocalExterior,
        TBCTEDEFECTODto dto
    )
    {
        try
        {
            var existing = await _repository.GetByIdAsync(ciaCodigo, cdfLocalExterior);
            if (existing == null)
                return new ApiResponse<TBCTEDEFECTODto>(false, "Default de cliente no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.CdfLocalExterior = cdfLocalExterior;
            var entity = _mapper.Map<TBCTEDEFECTO>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBCTEDEFECTODto>(updated);
            return new ApiResponse<TBCTEDEFECTODto>(
                true,
                "Default de cliente actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar default de cliente");
            return new ApiResponse<TBCTEDEFECTODto>(
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
            _logger.LogError(ex, "Error al actualizar default de cliente");
            return new ApiResponse<TBCTEDEFECTODto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<bool>> DeleteAsync(int ciaCodigo, string cdfLocalExterior)
    {
        try
        {
            var deleted = await _repository.DeleteAsync(ciaCodigo, cdfLocalExterior);
            if (!deleted)
                return new ApiResponse<bool>(false, "Default de cliente no encontrado")
                {
                    StatusCode = 404,
                };

            return new ApiResponse<bool>(true, "Default de cliente eliminado exitosamente", true)
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al eliminar default de cliente");
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
            _logger.LogError(ex, "Error al eliminar default de cliente");
            return new ApiResponse<bool>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
