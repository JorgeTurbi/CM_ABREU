using ApiCm.Commons;
using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Repositories.Interfaces.CuentasPorCobrar;
using ApiCm.Services.Interfaces.CuentasPorCobrar;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Services.CuentasPorCobrar;

public class DoctoCxcService : IDoctoCxcService
{
    private readonly IDoctoCxcRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<DoctoCxcService> _logger;

    public DoctoCxcService(
        IDoctoCxcRepository repository,
        IMapper mapper,
        ILogger<DoctoCxcService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<PagedResponse<List<TBDOCTOCXCDto>>> GetAllAsync(PaginationRequest pagination)
    {
        try
        {
            var (items, totalCount) = await _repository.GetAllAsync(pagination);
            var dtos = _mapper.Map<List<TBDOCTOCXCDto>>(items);
            return new PagedResponse<List<TBDOCTOCXCDto>>(
                dtos,
                totalCount,
                pagination.PageNumber,
                pagination.PageSize
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener documentos CXC");
            return new PagedResponse<List<TBDOCTOCXCDto>>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBDOCTOCXCDto>> GetByIdAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno
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
                dxcAno
            );
            if (entity == null)
                return new ApiResponse<TBDOCTOCXCDto>(false, "Documento CXC no encontrado")
                {
                    StatusCode = 404,
                };

            var dto = _mapper.Map<TBDOCTOCXCDto>(entity);
            return new ApiResponse<TBDOCTOCXCDto>(true, "Documento CXC obtenido exitosamente", dto)
            {
                StatusCode = 200,
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error al obtener documento CXC {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno
            );
            return new ApiResponse<TBDOCTOCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBDOCTOCXCDto>> CreateAsync(TBDOCTOCXCDto dto)
    {
        try
        {
            var entity = _mapper.Map<TBDOCTOCXC>(dto);
            var created = await _repository.CreateAsync(entity);
            var resultDto = _mapper.Map<TBDOCTOCXCDto>(created);
            return new ApiResponse<TBDOCTOCXCDto>(
                true,
                "Documento CXC creado exitosamente",
                resultDto
            )
            {
                StatusCode = 201,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al crear documento CXC");
            return new ApiResponse<TBDOCTOCXCDto>(
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
            _logger.LogError(ex, "Error al crear documento CXC");
            return new ApiResponse<TBDOCTOCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }

    public async Task<ApiResponse<TBDOCTOCXCDto>> UpdateAsync(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        TBDOCTOCXCDto dto
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
                dxcAno
            );
            if (existing == null)
                return new ApiResponse<TBDOCTOCXCDto>(false, "Documento CXC no encontrado")
                {
                    StatusCode = 404,
                };

            dto.CiaCodigo = ciaCodigo;
            dto.OfiCodigo = ofiCodigo;
            dto.MonCodigo = monCodigo;
            dto.TdcTipo = tdcTipo;
            dto.TdcCodigo = tdcCodigo;
            dto.DxcAno = dxcAno;
            var entity = _mapper.Map<TBDOCTOCXC>(dto);
            var updated = await _repository.UpdateAsync(entity);
            var resultDto = _mapper.Map<TBDOCTOCXCDto>(updated);
            return new ApiResponse<TBDOCTOCXCDto>(
                true,
                "Documento CXC actualizado exitosamente",
                resultDto
            )
            {
                StatusCode = 200,
            };
        }
        catch (DbUpdateException ex)
        {
            _logger.LogWarning(ex, "Error de BD al actualizar documento CXC");
            return new ApiResponse<TBDOCTOCXCDto>(
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
                "Error al actualizar documento CXC {CiaCodigo}/{OfiCodigo}/{MonCodigo}/{TdcTipo}/{TdcCodigo}/{DxcAno}",
                ciaCodigo,
                ofiCodigo,
                monCodigo,
                tdcTipo,
                tdcCodigo,
                dxcAno
            );
            return new ApiResponse<TBDOCTOCXCDto>(false, "Ocurrió un error")
            {
                StatusCode = 500,
                Errors = [ex.Message],
            };
        }
    }
}
