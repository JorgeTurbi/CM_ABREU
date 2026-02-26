using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using ApiCm.Services.Interfaces.CuentasPorCobrar;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.CuentasPorCobrar;

public class TipoDocCxcService : ITipoDocCxcService
{
    private readonly ITipoDocCxcRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<TipoDocCxcService> _logger;

    public TipoDocCxcService(
        ITipoDocCxcRepository repository,
        IMapper mapper,
        ILogger<TipoDocCxcService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBTIPODOCCXCDto>>> GetAllAsync(
        PaginationRequest pagination
    )
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBTIPODOCCXCDto>>(items);
            return new PagedResponse<List<TBTIPODOCCXCDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener tipos de documento CXC");
            return new PagedResponse<List<TBTIPODOCCXCDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBTIPODOCCXCDto>> GetByIdAsync(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo
    )
    {
        try
        {
            var entity = await _repository.GetByIdAsync(ciaCodigo, monCodigo, tdcTipo, tdcCodigo);
            if (entity == null)
                return new ApiResponse<TBTIPODOCCXCDto>(false, "Tipo documento CXC no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBTIPODOCCXCDto>(entity);
            return new ApiResponse<TBTIPODOCCXCDto>(
                true,
                "Tipo documento CXC obtenido exitosamente",
                dto
            )
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error al obtener tipo documento CXC {CiaCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}",
                ciaCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo
            );
            return new ApiResponse<TBTIPODOCCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBTIPODOCCXCDto>> CreateAsync(TBTIPODOCCXCDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBTIPODOCCXC>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBTIPODOCCXCDto>(created);
            return new ApiResponse<TBTIPODOCCXCDto>(
                true,
                "Tipo documento CXC creado exitosamente",
                resultDto
            )
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear tipo documento CXC");
            return new ApiResponse<TBTIPODOCCXCDto>(
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
            _logger.LogError(ex, "Error al crear tipo documento CXC");
            return new ApiResponse<TBTIPODOCCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBTIPODOCCXCDto>> UpdateAsync(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        TBTIPODOCCXCDto dto
    )
    {
        try
        {
            var existing = await _repository.GetByIdAsync(ciaCodigo, monCodigo, tdcTipo, tdcCodigo);
            if (existing == null)
                return new ApiResponse<TBTIPODOCCXCDto>(false, "Tipo documento CXC no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.MonCodigo = monCodigo;
            dto.TdcTipo = tdcTipo;
            dto.TdcCodigo = tdcCodigo;
            var entity = _mapper.Map<TBTIPODOCCXC>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBTIPODOCCXCDto>(updated);
            return new ApiResponse<TBTIPODOCCXCDto>(
                true,
                "Tipo documento CXC actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar tipo documento CXC");
            return new ApiResponse<TBTIPODOCCXCDto>(
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
                "Error al actualizar tipo documento CXC {CiaCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}",
                ciaCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo
            );
            return new ApiResponse<TBTIPODOCCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<bool>> DeleteAsync(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo
    )
    {
        try
        {
            var deleted = await _repository.DeleteAsync(ciaCodigo, monCodigo, tdcTipo, tdcCodigo);
            if (!deleted)
                return new ApiResponse<bool>(false, "Tipo documento CXC no encontrado")
                {
                    StatusCode = 404,
                };

            return new ApiResponse<bool>(true, "Tipo documento CXC eliminado exitosamente", true)
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(
                ex,
                "Error de BD al eliminar tipo documento CXC {CiaCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}",
                ciaCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo
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
                "Error al eliminar tipo documento CXC {CiaCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}",
                ciaCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo
            );
            return new ApiResponse<bool>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
