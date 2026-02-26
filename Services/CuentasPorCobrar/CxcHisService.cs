using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using ApiCm.Services.Interfaces.CuentasPorCobrar;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.CuentasPorCobrar;

public class CxcHisService : ICxcHisService
{
    private readonly ICxcHisRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<CxcHisService> _logger;

    public CxcHisService(
        ICxcHisRepository repository,
        IMapper mapper,
        ILogger<CxcHisService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBCXCHISDto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBCXCHISDto>>(items);
            return new PagedResponse<List<TBCXCHISDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener CXC históricos");
            return new PagedResponse<List<TBCXCHISDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCXCHISDto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string cchModulo,
        string cchTipo,
        int cchCodigo,
        string cchAno,
        int cchNumero,
        int cchSecuencia,
        int cchSubsec
    )
    {
        try
        {
            var entity = await _repository.GetByIdAsync(
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                cchModulo,
                cchTipo,
                cchCodigo,
                cchAno,
                cchNumero,
                cchSecuencia,
                cchSubsec
            );
            if (entity == null)
                return new ApiResponse<TBCXCHISDto>(false, "CXC histórico no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBCXCHISDto>(entity);
            return new ApiResponse<TBCXCHISDto>(true, "CXC histórico obtenido exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error al obtener CXC histórico {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{CchModulo}/{CchTipo}/{CchCodigo}/{CchAno}/{CchNumero}/{CchSecuencia}/{CchSubsec}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                cchModulo,
                cchTipo,
                cchCodigo,
                cchAno,
                cchNumero,
                cchSecuencia,
                cchSubsec
            );
            return new ApiResponse<TBCXCHISDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCXCHISDto>> CreateAsync(TBCXCHISDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBCXCHIS>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBCXCHISDto>(created);
            return new ApiResponse<TBCXCHISDto>(
                true,
                "CXC histórico creado exitosamente",
                resultDto
            )
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear CXC histórico");
            return new ApiResponse<TBCXCHISDto>(
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
            _logger.LogError(ex, "Error al crear CXC histórico");
            return new ApiResponse<TBCXCHISDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCXCHISDto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string cchModulo,
        string cchTipo,
        int cchCodigo,
        string cchAno,
        int cchNumero,
        int cchSecuencia,
        int cchSubsec,
        TBCXCHISDto dto
    )
    {
        try
        {
            var existing = await _repository.GetByIdAsync(
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                cchModulo,
                cchTipo,
                cchCodigo,
                cchAno,
                cchNumero,
                cchSecuencia,
                cchSubsec
            );
            if (existing == null)
                return new ApiResponse<TBCXCHISDto>(false, "CXC histórico no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.OfiCodigo = ofiCodigo;
            dto.MonCodigo = monCodigo;
            dto.CchModulo = cchModulo;
            dto.CchTipo = cchTipo;
            dto.CchCodigo = cchCodigo;
            dto.CchAno = cchAno;
            dto.CchNumero = cchNumero;
            dto.CchSecuencia = cchSecuencia;
            dto.CchSubsec = cchSubsec;
            var entity = _mapper.Map<TBCXCHIS>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBCXCHISDto>(updated);
            return new ApiResponse<TBCXCHISDto>(
                true,
                "CXC histórico actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar CXC histórico");
            return new ApiResponse<TBCXCHISDto>(
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
                "Error al actualizar CXC histórico {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{CchModulo}/{CchTipo}/{CchCodigo}/{CchAno}/{CchNumero}/{CchSecuencia}/{CchSubsec}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                cchModulo,
                cchTipo,
                cchCodigo,
                cchAno,
                cchNumero,
                cchSecuencia,
                cchSubsec
            );
            return new ApiResponse<TBCXCHISDto>(false, "Ocurrió un error")
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
        string cchModulo,
        string cchTipo,
        int cchCodigo,
        string cchAno,
        int cchNumero,
        int cchSecuencia,
        int cchSubsec
    )
    {
        try
        {
            var deleted = await _repository.DeleteAsync(
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                cchModulo,
                cchTipo,
                cchCodigo,
                cchAno,
                cchNumero,
                cchSecuencia,
                cchSubsec
            );
            if (!deleted)
                return new ApiResponse<bool>(false, "CXC histórico no encontrado")
                {
                    StatusCode = 404,
                };

            return new ApiResponse<bool>(true, "CXC histórico eliminado exitosamente", true)
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(
                ex,
                "Error de BD al eliminar CXC histórico {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{CchModulo}/{CchTipo}/{CchCodigo}/{CchAno}/{CchNumero}/{CchSecuencia}/{CchSubsec}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                cchModulo,
                cchTipo,
                cchCodigo,
                cchAno,
                cchNumero,
                cchSecuencia,
                cchSubsec
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
                "Error al eliminar CXC histórico {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{CchModulo}/{CchTipo}/{CchCodigo}/{CchAno}/{CchNumero}/{CchSecuencia}/{CchSubsec}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                cchModulo,
                cchTipo,
                cchCodigo,
                cchAno,
                cchNumero,
                cchSecuencia,
                cchSubsec
            );
            return new ApiResponse<bool>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
