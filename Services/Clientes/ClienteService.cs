using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;
using ApiCm.Entities.Clientes;
using ApiCm.Repositories.Interfaces.Clientes;
using ApiCm.Services.Interfaces.Clientes;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.Clientes;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<ClienteService> _logger;

    public ClienteService(
        IClienteRepository repository,
        IMapper mapper,
        ILogger<ClienteService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBCLIENTEDto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBCLIENTEDto>>(items);
            return new PagedResponse<List<TBCLIENTEDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener clientes");
            return new PagedResponse<List<TBCLIENTEDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCLIENTEDto>> GetByIdAsync(int ciaCodigo, string cteCodigo)
    {
        try
        {
            var entity = await _repository.GetByIdAsync(ciaCodigo, cteCodigo);
            if (entity == null)
                return new ApiResponse<TBCLIENTEDto>(false, "Cliente no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBCLIENTEDto>(entity);
            return new ApiResponse<TBCLIENTEDto>(true, "Cliente obtenido exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error al obtener cliente {Compania}/{Codigo}",
                ciaCodigo,
                cteCodigo
            );
            return new ApiResponse<TBCLIENTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCLIENTEDto>> CreateAsync(TBCLIENTEDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBCLIENTE>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBCLIENTEDto>(created);
            return new ApiResponse<TBCLIENTEDto>(true, "Cliente creado exitosamente", resultDto)
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear cliente");
            return new ApiResponse<TBCLIENTEDto>(
                false,
                "Error al crear: verifique FKs (ciudad, grupo, tipo cliente) o registro duplicado"
            )
            {
                StatusCode = 400,
                Errors = [ex.InnerException?.Message ?? ex.Message],
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al crear cliente");
            return new ApiResponse<TBCLIENTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBCLIENTEDto>> UpdateAsync(
        int ciaCodigo,
        string cteCodigo,
        TBCLIENTEDto dto
    )
    {
        try
        {
            var existing = await _repository.GetByIdAsync(ciaCodigo, cteCodigo);
            if (existing == null)
                return new ApiResponse<TBCLIENTEDto>(false, "Cliente no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.CteCodigo = cteCodigo;
            var entity = _mapper.Map<TBCLIENTE>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBCLIENTEDto>(updated);
            return new ApiResponse<TBCLIENTEDto>(
                true,
                "Cliente actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar cliente");
            return new ApiResponse<TBCLIENTEDto>(
                false,
                "Error al actualizar: verifique FKs (ciudad, grupo, tipo cliente)"
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
                "Error al actualizar cliente {Compania}/{Codigo}",
                ciaCodigo,
                cteCodigo
            );
            return new ApiResponse<TBCLIENTEDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
