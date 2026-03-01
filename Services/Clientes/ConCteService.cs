using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using ApiCm.Services.Interfaces.Clientes;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.Clientes;

public class ConCteService : IConCteService
{
    private readonly IConCteRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<ConCteService> _logger;

    public ConCteService(
        IConCteRepository repository,
        IMapper mapper,
        ILogger<ConCteService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBCONCTEDto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBCONCTEDto>>(items);
            return new PagedResponse<List<TBCONCTEDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener contactos de cliente");
            return new PagedResponse<List<TBCONCTEDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCONCTEDto>> GetByIdAsync(
        int ciaCodigo,
        string cteCodigo,
        int cclCodigo
    )
    {
        try
        {
            var entity = await _repository.GetByIdAsync(ciaCodigo, cteCodigo, cclCodigo);
            if (entity == null)
                return new ApiResponse<TBCONCTEDto>(false, "Contacto de cliente no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBCONCTEDto>(entity);
            return new ApiResponse<TBCONCTEDto>(true, "Registro obtenido exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener contacto de cliente");
            return new ApiResponse<TBCONCTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCONCTEDto>> CreateAsync(TBCONCTEDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBCONCTE>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBCONCTEDto>(created);
            return new ApiResponse<TBCONCTEDto>(
                true,
                "Contacto de cliente creado exitosamente",
                resultDto
            )
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear contacto de cliente");
            return new ApiResponse<TBCONCTEDto>(
                false,
                "Error al crear: verifique que el cliente exista (FK) o que no sea duplicado"
            )
            {
                StatusCode = 400,
                Errors = [ex.InnerException?.Message ?? ex.Message],
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al crear contacto de cliente");
            return new ApiResponse<TBCONCTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCONCTEDto>> UpdateAsync(
        int ciaCodigo,
        string cteCodigo,
        int cclCodigo,
        TBCONCTEDto dto
    )
    {
        try
        {
            var existing = await _repository.GetByIdAsync(ciaCodigo, cteCodigo, cclCodigo);
            if (existing == null)
                return new ApiResponse<TBCONCTEDto>(false, "Contacto de cliente no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.CteCodigo = cteCodigo;
            dto.CclCodigo = cclCodigo;
            var entity = _mapper.Map<TBCONCTE>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBCONCTEDto>(updated);
            return new ApiResponse<TBCONCTEDto>(
                true,
                "Contacto de cliente actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar contacto de cliente");
            return new ApiResponse<TBCONCTEDto>(
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
            _logger.LogError(ex, "Error al actualizar contacto de cliente");
            return new ApiResponse<TBCONCTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
