using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using ApiCm.Services.Interfaces.Clientes;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.Clientes;

public class CiudadService : ICiudadService
{
    private readonly ICiudadRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<CiudadService> _logger;

    public CiudadService(
        ICiudadRepository repository,
        IMapper mapper,
        ILogger<CiudadService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBCIUDADDto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBCIUDADDto>>(items);
            return new PagedResponse<List<TBCIUDADDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener ciudades");
            return new PagedResponse<List<TBCIUDADDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCIUDADDto>> GetByIdAsync(int cdaCodigo)
    {
        try
        {
            var entity = await _repository.GetByIdAsync(cdaCodigo);
            if (entity == null)
                return new ApiResponse<TBCIUDADDto>(false, "Ciudad no encontrada")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBCIUDADDto>(entity);
            return new ApiResponse<TBCIUDADDto>(true, "Ciudad obtenida exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener ciudad {Codigo}", cdaCodigo);
            return new ApiResponse<TBCIUDADDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCIUDADDto>> CreateAsync(TBCIUDADDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBCIUDAD>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBCIUDADDto>(created);
            return new ApiResponse<TBCIUDADDto>(true, "Ciudad creada exitosamente", resultDto)
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear ciudad");
            return new ApiResponse<TBCIUDADDto>(
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
            _logger.LogError(ex, "Error al crear ciudad");
            return new ApiResponse<TBCIUDADDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCIUDADDto>> UpdateAsync(int cdaCodigo, TBCIUDADDto dto)
    {
        try
        {
            var existing = await _repository.GetByIdAsync(cdaCodigo);
            if (existing == null)
                return new ApiResponse<TBCIUDADDto>(false, "Ciudad no encontrada")
                {
                    StatusCode = 404,
                };

            dto.CdaCodigo = cdaCodigo;
            var entity = _mapper.Map<TBCIUDAD>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBCIUDADDto>(updated);
            return new ApiResponse<TBCIUDADDto>(true, "Ciudad actualizada exitosamente", resultDto)
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar ciudad");
            return new ApiResponse<TBCIUDADDto>(
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
            _logger.LogError(ex, "Error al actualizar ciudad {Codigo}", cdaCodigo);
            return new ApiResponse<TBCIUDADDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
