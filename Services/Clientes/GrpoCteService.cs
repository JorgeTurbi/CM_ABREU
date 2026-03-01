using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using ApiCm.Services.Interfaces.Clientes;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.Clientes;

public class GrpoCteService : IGrpoCteService
{
    private readonly IGrpoCteRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<GrpoCteService> _logger;

    public GrpoCteService(
        IGrpoCteRepository repository,
        IMapper mapper,
        ILogger<GrpoCteService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBGRPOCTEDto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBGRPOCTEDto>>(items);
            return new PagedResponse<List<TBGRPOCTEDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener grupos de cliente");
            return new PagedResponse<List<TBGRPOCTEDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBGRPOCTEDto>> GetByIdAsync(int ciaCodigo, int gctCodigo)
    {
        try
        {
            var entity = await _repository.GetByIdAsync(ciaCodigo, gctCodigo);
            if (entity == null)
                return new ApiResponse<TBGRPOCTEDto>(false, "Grupo de cliente no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBGRPOCTEDto>(entity);
            return new ApiResponse<TBGRPOCTEDto>(true, "Grupo obtenido exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error al obtener grupo de cliente {Compania}/{Codigo}",
                ciaCodigo,
                gctCodigo
            );
            return new ApiResponse<TBGRPOCTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBGRPOCTEDto>> CreateAsync(TBGRPOCTEDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBGRPOCTE>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBGRPOCTEDto>(created);
            return new ApiResponse<TBGRPOCTEDto>(
                true,
                "Grupo de cliente creado exitosamente",
                resultDto
            )
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear grupo de cliente");
            return new ApiResponse<TBGRPOCTEDto>(
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
            _logger.LogError(ex, "Error al crear grupo de cliente");
            return new ApiResponse<TBGRPOCTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBGRPOCTEDto>> UpdateAsync(
        int ciaCodigo,
        int gctCodigo,
        TBGRPOCTEDto dto
    )
    {
        try
        {
            var existing = await _repository.GetByIdAsync(ciaCodigo, gctCodigo);
            if (existing == null)
                return new ApiResponse<TBGRPOCTEDto>(false, "Grupo de cliente no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.GctCodigo = gctCodigo;
            var entity = _mapper.Map<TBGRPOCTE>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBGRPOCTEDto>(updated);
            return new ApiResponse<TBGRPOCTEDto>(
                true,
                "Grupo de cliente actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar grupo de cliente");
            return new ApiResponse<TBGRPOCTEDto>(
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
                "Error al actualizar grupo de cliente {Compania}/{Codigo}",
                ciaCodigo,
                gctCodigo
            );
            return new ApiResponse<TBGRPOCTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
