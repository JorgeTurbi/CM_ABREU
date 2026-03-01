using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using ApiCm.Services.Interfaces.Clientes;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.Clientes;

public class TipoCteMonService : ITipoCteMonService
{
    private readonly ITipoCteMonRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<TipoCteMonService> _logger;

    public TipoCteMonService(
        ITipoCteMonRepository repository,
        IMapper mapper,
        ILogger<TipoCteMonService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBTIPOCTEMONDto>>> GetAllAsync(
        PaginationRequest pagination
    )
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBTIPOCTEMONDto>>(items);
            return new PagedResponse<List<TBTIPOCTEMONDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener tipos de cliente por moneda");
            return new PagedResponse<List<TBTIPOCTEMONDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBTIPOCTEMONDto>> GetByIdAsync(
        int ciaCodigo,
        int tclCodigo,
        int monCodigo
    )
    {
        try
        {
            var entity = await _repository.GetByIdAsync(ciaCodigo, tclCodigo, monCodigo);
            if (entity == null)
                return new ApiResponse<TBTIPOCTEMONDto>(
                    false,
                    "Tipo de cliente por moneda no encontrado"
                )
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBTIPOCTEMONDto>(entity);
            return new ApiResponse<TBTIPOCTEMONDto>(true, "Registro obtenido exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener tipo de cliente por moneda");
            return new ApiResponse<TBTIPOCTEMONDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBTIPOCTEMONDto>> CreateAsync(TBTIPOCTEMONDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBTIPOCTEMON>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBTIPOCTEMONDto>(created);
            return new ApiResponse<TBTIPOCTEMONDto>(
                true,
                "Tipo de cliente por moneda creado exitosamente",
                resultDto
            )
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear tipo de cliente por moneda");
            return new ApiResponse<TBTIPOCTEMONDto>(
                false,
                "Error al crear: el tipo de cliente (FK) no existe o registro duplicado"
            )
            {
                StatusCode = 400,
                Errors = [ex.InnerException?.Message ?? ex.Message],
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al crear tipo de cliente por moneda");
            return new ApiResponse<TBTIPOCTEMONDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBTIPOCTEMONDto>> UpdateAsync(
        int ciaCodigo,
        int tclCodigo,
        int monCodigo,
        TBTIPOCTEMONDto dto
    )
    {
        try
        {
            var existing = await _repository.GetByIdAsync(ciaCodigo, tclCodigo, monCodigo);
            if (existing == null)
                return new ApiResponse<TBTIPOCTEMONDto>(
                    false,
                    "Tipo de cliente por moneda no encontrado"
                )
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.TclCodigo = tclCodigo;
            dto.MonCodigo = monCodigo;
            var entity = _mapper.Map<TBTIPOCTEMON>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBTIPOCTEMONDto>(updated);
            return new ApiResponse<TBTIPOCTEMONDto>(
                true,
                "Registro actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar tipo de cliente por moneda");
            return new ApiResponse<TBTIPOCTEMONDto>(
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
            _logger.LogError(ex, "Error al actualizar tipo de cliente por moneda");
            return new ApiResponse<TBTIPOCTEMONDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
