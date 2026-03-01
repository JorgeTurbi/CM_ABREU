using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using ApiCm.Services.Interfaces.CuentasPorCobrar;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.CuentasPorCobrar;

public class CxcActService : ICxcActService
{
    private readonly ICxcActRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<CxcActService> _logger;

    public CxcActService(
        ICxcActRepository repository,
        IMapper mapper,
        ILogger<CxcActService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBCXCACTDto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBCXCACTDto>>(items);
            return new PagedResponse<List<TBCXCACTDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener CXC actuales");
            return new PagedResponse<List<TBCXCACTDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCXCACTDto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string ccaModulo,
        string ccaTipo,
        int ccaCodigo,
        string ccaAno,
        int ccaNumero,
        int ccaSecuencia,
        int ccaSubsec
    )
    {
        try
        {
            var entity = await _repository.GetByIdAsync(
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                ccaModulo,
                ccaTipo,
                ccaCodigo,
                ccaAno,
                ccaNumero,
                ccaSecuencia,
                ccaSubsec
            );
            if (entity == null)
                return new ApiResponse<TBCXCACTDto>(false, "CXC actual no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBCXCACTDto>(entity);
            return new ApiResponse<TBCXCACTDto>(true, "CXC actual obtenido exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error al obtener CXC actual {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{CcaModulo}/{CcaTipo}/{CcaCodigo}/{CcaAno}/{CcaNumero}/{CcaSecuencia}/{CcaSubsec}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                ccaModulo,
                ccaTipo,
                ccaCodigo,
                ccaAno,
                ccaNumero,
                ccaSecuencia,
                ccaSubsec
            );
            return new ApiResponse<TBCXCACTDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCXCACTDto>> CreateAsync(TBCXCACTDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBCXCACT>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBCXCACTDto>(created);
            return new ApiResponse<TBCXCACTDto>(true, "CXC actual creado exitosamente", resultDto)
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear CXC actual");
            return new ApiResponse<TBCXCACTDto>(
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
            _logger.LogError(ex, "Error al crear CXC actual");
            return new ApiResponse<TBCXCACTDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCXCACTDto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string ccaModulo,
        string ccaTipo,
        int ccaCodigo,
        string ccaAno,
        int ccaNumero,
        int ccaSecuencia,
        int ccaSubsec,
        TBCXCACTDto dto
    )
    {
        try
        {
            var existing = await _repository.GetByIdAsync(
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                ccaModulo,
                ccaTipo,
                ccaCodigo,
                ccaAno,
                ccaNumero,
                ccaSecuencia,
                ccaSubsec
            );
            if (existing == null)
                return new ApiResponse<TBCXCACTDto>(false, "CXC actual no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.OfiCodigo = ofiCodigo;
            dto.MonCodigo = monCodigo;
            dto.CcaModulo = ccaModulo;
            dto.CcaTipo = ccaTipo;
            dto.CcaCodigo = ccaCodigo;
            dto.CcaAno = ccaAno;
            dto.CcaNumero = ccaNumero;
            dto.CcaSecuencia = ccaSecuencia;
            dto.CcaSubsec = ccaSubsec;
            var entity = _mapper.Map<TBCXCACT>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBCXCACTDto>(updated);
            return new ApiResponse<TBCXCACTDto>(
                true,
                "CXC actual actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar CXC actual");
            return new ApiResponse<TBCXCACTDto>(
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
                "Error al actualizar CXC actual {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{CcaModulo}/{CcaTipo}/{CcaCodigo}/{CcaAno}/{CcaNumero}/{CcaSecuencia}/{CcaSubsec}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                ccaModulo,
                ccaTipo,
                ccaCodigo,
                ccaAno,
                ccaNumero,
                ccaSecuencia,
                ccaSubsec
            );
            return new ApiResponse<TBCXCACTDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
