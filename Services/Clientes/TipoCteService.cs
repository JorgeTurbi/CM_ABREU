using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using ApiCm.Services.Interfaces.Clientes;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.Clientes;

public class TipoCteService : ITipoCteService
{
    private readonly ITipoCteRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<TipoCteService> _logger;

    public TipoCteService(
        ITipoCteRepository repository,
        IMapper mapper,
        ILogger<TipoCteService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBTIPOCTEDto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBTIPOCTEDto>>(items);
            return new PagedResponse<List<TBTIPOCTEDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener tipos de cliente");
            return new PagedResponse<List<TBTIPOCTEDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBTIPOCTEDto>> GetByIdAsync(int ciaCodigo, int tclCodigo)
    {
        try
        {
            var entity = await _repository.GetByIdAsync(ciaCodigo, tclCodigo);
            if (entity == null)
                return new ApiResponse<TBTIPOCTEDto>(false, "Tipo de cliente no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBTIPOCTEDto>(entity);
            return new ApiResponse<TBTIPOCTEDto>(true, "Tipo de cliente obtenido exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error al obtener tipo de cliente {Compania}/{Codigo}",
                ciaCodigo,
                tclCodigo
            );
            return new ApiResponse<TBTIPOCTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBTIPOCTEDto>> CreateAsync(TBTIPOCTEDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBTIPOCTE>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBTIPOCTEDto>(created);
            return new ApiResponse<TBTIPOCTEDto>(
                true,
                "Tipo de cliente creado exitosamente",
                resultDto
            )
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear tipo de cliente");
            return new ApiResponse<TBTIPOCTEDto>(
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
            _logger.LogError(ex, "Error al crear tipo de cliente");
            return new ApiResponse<TBTIPOCTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBTIPOCTEDto>> UpdateAsync(
        int ciaCodigo,
        int tclCodigo,
        TBTIPOCTEDto dto
    )
    {
        try
        {
            var existing = await _repository.GetByIdAsync(ciaCodigo, tclCodigo);
            if (existing == null)
                return new ApiResponse<TBTIPOCTEDto>(false, "Tipo de cliente no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.TclCodigo = tclCodigo;
            var entity = _mapper.Map<TBTIPOCTE>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBTIPOCTEDto>(updated);
            return new ApiResponse<TBTIPOCTEDto>(
                true,
                "Tipo de cliente actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar tipo de cliente");
            return new ApiResponse<TBTIPOCTEDto>(
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
                "Error al actualizar tipo de cliente {Compania}/{Codigo}",
                ciaCodigo,
                tclCodigo
            );
            return new ApiResponse<TBTIPOCTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<bool>> DeleteAsync(int ciaCodigo, int tclCodigo)
    {
        try
        {
            var deleted = await _repository.DeleteAsync(ciaCodigo, tclCodigo);
            if (!deleted)
                return new ApiResponse<bool>(false, "Tipo de cliente no encontrado")
                {
                    StatusCode = 404,
                };

            return new ApiResponse<bool>(true, "Tipo de cliente eliminado exitosamente", true)
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(
                ex,
                "Error de BD al eliminar tipo de cliente {Compania}/{Codigo}",
                ciaCodigo,
                tclCodigo
            );
            return new ApiResponse<bool>(
                false,
                "No se puede eliminar: existen clientes o tipos de cliente por moneda asociados"
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
                "Error al eliminar tipo de cliente {Compania}/{Codigo}",
                ciaCodigo,
                tclCodigo
            );
            return new ApiResponse<bool>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
