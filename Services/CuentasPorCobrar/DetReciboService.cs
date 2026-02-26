using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using ApiCm.Services.Interfaces.CuentasPorCobrar;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.CuentasPorCobrar;

public class DetReciboService : IDetReciboService
{
    private readonly IDetReciboRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<DetReciboService> _logger;

    public DetReciboService(
        IDetReciboRepository repository,
        IMapper mapper,
        ILogger<DetReciboService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBDETRECIBODto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBDETRECIBODto>>(items);
            return new PagedResponse<List<TBDETRECIBODto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener detalles de recibo");
            return new PagedResponse<List<TBDETRECIBODto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBDETRECIBODto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        int drcSecuencia
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
                crcNumero,
                drcSecuencia
            );
            if (entity == null)
                return new ApiResponse<TBDETRECIBODto>(false, "Detalle recibo no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBDETRECIBODto>(entity);
            return new ApiResponse<TBDETRECIBODto>(
                true,
                "Detalle recibo obtenido exitosamente",
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
                "Error al obtener detalle recibo {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CrcNumero}/{DrcSecuencia}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                crcNumero,
                drcSecuencia
            );
            return new ApiResponse<TBDETRECIBODto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBDETRECIBODto>> CreateAsync(TBDETRECIBODto dto)
    {
        try
        {
            var entity = _mapper.Map<TBDETRECIBO>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBDETRECIBODto>(created);
            return new ApiResponse<TBDETRECIBODto>(
                true,
                "Detalle recibo creado exitosamente",
                resultDto
            )
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear detalle recibo");
            return new ApiResponse<TBDETRECIBODto>(
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
            _logger.LogError(ex, "Error al crear detalle recibo");
            return new ApiResponse<TBDETRECIBODto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBDETRECIBODto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        int drcSecuencia,
        TBDETRECIBODto dto
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
                crcNumero,
                drcSecuencia
            );
            if (existing == null)
                return new ApiResponse<TBDETRECIBODto>(false, "Detalle recibo no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.OfiCodigo = ofiCodigo;
            dto.MonCodigo = monCodigo;
            dto.TdcTipo = tdcTipo;
            dto.TdcCodigo = tdcCodigo;
            dto.DxcAno = dxcAno;
            dto.CrcNumero = crcNumero;
            dto.DrcSecuencia = drcSecuencia;
            var entity = _mapper.Map<TBDETRECIBO>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBDETRECIBODto>(updated);
            return new ApiResponse<TBDETRECIBODto>(
                true,
                "Detalle recibo actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar detalle recibo");
            return new ApiResponse<TBDETRECIBODto>(
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
                "Error al actualizar detalle recibo {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CrcNumero}/{DrcSecuencia}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                crcNumero,
                drcSecuencia
            );
            return new ApiResponse<TBDETRECIBODto>(false, "Ocurrió un error")
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
        int crcNumero,
        int drcSecuencia
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
                crcNumero,
                drcSecuencia
            );
            if (!deleted)
                return new ApiResponse<bool>(false, "Detalle recibo no encontrado")
                {
                    StatusCode = 404,
                };

            return new ApiResponse<bool>(true, "Detalle recibo eliminado exitosamente", true)
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(
                ex,
                "Error de BD al eliminar detalle recibo {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CrcNumero}/{DrcSecuencia}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                crcNumero,
                drcSecuencia
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
                "Error al eliminar detalle recibo {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CrcNumero}/{DrcSecuencia}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                crcNumero,
                drcSecuencia
            );
            return new ApiResponse<bool>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
