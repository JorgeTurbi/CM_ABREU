using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using ApiCm.Services.Interfaces.CuentasPorCobrar;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.CuentasPorCobrar;

public class CabReciboService : ICabReciboService
{
    private readonly ICabReciboRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<CabReciboService> _logger;

    public CabReciboService(
        ICabReciboRepository repository,
        IMapper mapper,
        ILogger<CabReciboService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBCABRECIBODto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBCABRECIBODto>>(items);
            return new PagedResponse<List<TBCABRECIBODto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener recibos");
            return new PagedResponse<List<TBCABRECIBODto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCABRECIBODto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero
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
                crcNumero
            );
            if (entity == null)
                return new ApiResponse<TBCABRECIBODto>(false, "Recibo no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBCABRECIBODto>(entity);
            return new ApiResponse<TBCABRECIBODto>(true, "Recibo obtenido exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error al obtener recibo {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CrcNumero}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                crcNumero
            );
            return new ApiResponse<TBCABRECIBODto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCABRECIBODto>> CreateAsync(TBCABRECIBODto dto)
    {
        try
        {
            var entity = _mapper.Map<TBCABRECIBO>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBCABRECIBODto>(created);
            return new ApiResponse<TBCABRECIBODto>(true, "Recibo creado exitosamente", resultDto)
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear recibo");
            return new ApiResponse<TBCABRECIBODto>(
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
            _logger.LogError(ex, "Error al crear recibo");
            return new ApiResponse<TBCABRECIBODto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCABRECIBODto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        int crcNumero,
        TBCABRECIBODto dto
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
                crcNumero
            );
            if (existing == null)
                return new ApiResponse<TBCABRECIBODto>(false, "Recibo no encontrado")
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
            var entity = _mapper.Map<TBCABRECIBO>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBCABRECIBODto>(updated);
            return new ApiResponse<TBCABRECIBODto>(
                true,
                "Recibo actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar recibo");
            return new ApiResponse<TBCABRECIBODto>(
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
                "Error al actualizar recibo {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CrcNumero}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                crcNumero
            );
            return new ApiResponse<TBCABRECIBODto>(false, "Ocurrió un error")
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
        int crcNumero
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
                crcNumero
            );
            if (!deleted)
                return new ApiResponse<bool>(false, "Recibo no encontrado") { StatusCode = 404 };

            return new ApiResponse<bool>(true, "Recibo eliminado exitosamente", true)
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(
                ex,
                "Error de BD al eliminar recibo {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CrcNumero}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                crcNumero
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
                "Error al eliminar recibo {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}/{CrcNumero}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno,
                crcNumero
            );
            return new ApiResponse<bool>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
