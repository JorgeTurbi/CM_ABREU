using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using ApiCm.Services.Interfaces.CuentasPorCobrar;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.CuentasPorCobrar;

public class CabMovCxcService : ICabMovCxcService
{
    private readonly ICabMovCxcRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<CabMovCxcService> _logger;

    public CabMovCxcService(
        ICabMovCxcRepository repository,
        IMapper mapper,
        ILogger<CabMovCxcService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBCABMOVCXCDto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBCABMOVCXCDto>>(items);
            return new PagedResponse<List<TBCABMOVCXCDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener movimientos CXC");
            return new PagedResponse<List<TBCABMOVCXCDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCABMOVCXCDto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero
    )
    {
        try
        {
            var entity = await _repository.GetByIdAsync(
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                cmcNumero
            );
            if (entity == null)
                return new ApiResponse<TBCABMOVCXCDto>(false, "Movimiento CXC no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBCABMOVCXCDto>(entity);
            return new ApiResponse<TBCABMOVCXCDto>(
                true,
                "Movimiento CXC obtenido exitosamente",
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
                "Error al obtener movimiento CXC {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CmcNumero}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                cmcNumero
            );
            return new ApiResponse<TBCABMOVCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCABMOVCXCDto>> CreateAsync(TBCABMOVCXCDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBCABMOVCXC>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBCABMOVCXCDto>(created);
            return new ApiResponse<TBCABMOVCXCDto>(
                true,
                "Movimiento CXC creado exitosamente",
                resultDto
            )
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear movimiento CXC");
            return new ApiResponse<TBCABMOVCXCDto>(
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
            _logger.LogError(ex, "Error al crear movimiento CXC");
            return new ApiResponse<TBCABMOVCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCABMOVCXCDto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        TBCABMOVCXCDto dto
    )
    {
        try
        {
            var existing = await _repository.GetByIdAsync(
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                cmcNumero
            );
            if (existing == null)
                return new ApiResponse<TBCABMOVCXCDto>(false, "Movimiento CXC no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.OfiCodigo = ofiCodigo;
            dto.MonCodigo = monCodigo;
            dto.TdcTipo = tdcTipo;
            dto.TdcCodigo = tdcCodigo;
            dto.DxcAno = dxcAno;
            dto.CmcNumero = cmcNumero;
            var entity = _mapper.Map<TBCABMOVCXC>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBCABMOVCXCDto>(updated);
            return new ApiResponse<TBCABMOVCXCDto>(
                true,
                "Movimiento CXC actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar movimiento CXC");
            return new ApiResponse<TBCABMOVCXCDto>(
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
                "Error al actualizar movimiento CXC {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CmcNumero}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                cmcNumero
            );
            return new ApiResponse<TBCABMOVCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<bool>> DeleteAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero
    )
    {
        try
        {
            var deleted = await _repository.DeleteAsync(
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                cmcNumero
            );
            if (!deleted)
                return new ApiResponse<bool>(false, "Movimiento CXC no encontrado")
                {
                    StatusCode = 404,
                };

            return new ApiResponse<bool>(true, "Movimiento CXC eliminado exitosamente", true)
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(
                ex,
                "Error de BD al eliminar movimiento CXC {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CmcNumero}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                cmcNumero
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
                "Error al eliminar movimiento CXC {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CmcNumero}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                cmcNumero
            );
            return new ApiResponse<bool>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
