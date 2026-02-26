using ApiCm.Commons.Pagination;
using ApiCm.DTOs.CuentasPorCobrar;
using ApiCm.Services.Interfaces.CuentasPorCobrar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiCm.Controllers;

[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName = "CuentasPorCobrar")]
[Authorize]
public class TipoDocCxcController : ControllerBase
{
    private readonly ITipoDocCxcService _service;

    public TipoDocCxcController(ITipoDocCxcService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationRequest pagination)
    {
        var result = await _service.GetAllAsync(pagination);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpGet("{ciaCodigo:int}/{monCodigo:int}/{tdcTipo}/{tdcCodigo:int}")]
    public async Task<IActionResult> GetById(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo
    )
    {
        var result = await _service.GetByIdAsync(ciaCodigo, monCodigo, tdcTipo, tdcCodigo);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TBTIPODOCCXCDto dto)
    {
        var result = await _service.CreateAsync(dto);
        return result.Success == true
            ? StatusCode(201, result)
            : StatusCode(result.StatusCode, result);
    }

    [HttpPut("{ciaCodigo:int}/{monCodigo:int}/{tdcTipo}/{tdcCodigo:int}")]
    public async Task<IActionResult> Update(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        [FromBody] TBTIPODOCCXCDto dto
    )
    {
        var result = await _service.UpdateAsync(ciaCodigo, monCodigo, tdcTipo, tdcCodigo, dto);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpDelete("{ciaCodigo:int}/{monCodigo:int}/{tdcTipo}/{tdcCodigo:int}")]
    public async Task<IActionResult> Delete(
        int ciaCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo
    )
    {
        var result = await _service.DeleteAsync(ciaCodigo, monCodigo, tdcTipo, tdcCodigo);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
