using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using ApiCm.Services.Interfaces.CuentasPorCobrar;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.CuentasPorCobrar;

public class DetMovCxcService : IDetMovCxcService
{
    private readonly IDetMovCxcRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<DetMovCxcService> _logger;

    public DetMovCxcService(
        IDetMovCxcRepository repository,
        IMapper mapper,
        ILogger<DetMovCxcService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBDETMOVCXCDto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBDETMOVCXCDto>>(items);
            return new PagedResponse<List<TBDETMOVCXCDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener detalles de movimiento CXC");
            return new PagedResponse<List<TBDETMOVCXCDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBDETMOVCXCDto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        int dmcSecuencia
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
                cmcNumero,
                dmcSecuencia
            );
            if (entity == null)
                return new ApiResponse<TBDETMOVCXCDto>(
                    false,
                    "Detalle movimiento CXC no encontrado"
                )
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBDETMOVCXCDto>(entity);
            return new ApiResponse<TBDETMOVCXCDto>(
                true,
                "Detalle movimiento CXC obtenido exitosamente",
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
                "Error al obtener detalle movimiento CXC {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CmcNumero}/{DmcSecuencia}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                cmcNumero,
                dmcSecuencia
            );
            return new ApiResponse<TBDETMOVCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBDETMOVCXCDto>> CreateAsync(TBDETMOVCXCDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBDETMOVCXC>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBDETMOVCXCDto>(created);
            return new ApiResponse<TBDETMOVCXCDto>(
                true,
                "Detalle movimiento CXC creado exitosamente",
                resultDto
            )
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear detalle movimiento CXC");
            return new ApiResponse<TBDETMOVCXCDto>(
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
            _logger.LogError(ex, "Error al crear detalle movimiento CXC");
            return new ApiResponse<TBDETMOVCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBDETMOVCXCDto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int cmcNumero,
        int dmcSecuencia,
        TBDETMOVCXCDto dto
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
                cmcNumero,
                dmcSecuencia
            );
            if (existing == null)
                return new ApiResponse<TBDETMOVCXCDto>(
                    false,
                    "Detalle movimiento CXC no encontrado"
                )
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
            dto.DmcSecuencia = dmcSecuencia;
            var entity = _mapper.Map<TBDETMOVCXC>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBDETMOVCXCDto>(updated);
            return new ApiResponse<TBDETMOVCXCDto>(
                true,
                "Detalle movimiento CXC actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar detalle movimiento CXC");
            return new ApiResponse<TBDETMOVCXCDto>(
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
                "Error al actualizar detalle movimiento CXC {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CmcNumero}/{DmcSecuencia}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                cmcNumero,
                dmcSecuencia
            );
            return new ApiResponse<TBDETMOVCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
