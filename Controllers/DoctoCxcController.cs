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
public class DoctoCxcController : ControllerBase
{
    private readonly IDoctoCxcService _service;

    public DoctoCxcController(IDoctoCxcService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationRequest pagination)
    {
        var result = await _service.GetAllAsync(pagination);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpGet(
        "{ciaCodigo:int}/{ofiCodigo:int}/{monCodigo:int}/{tdcTipo}/{tdcCodigo:int}/{dxcAno}"
    )]
    public async Task<IActionResult> GetById(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno
    )
    {
        var result = await _service.GetByIdAsync(
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            tdcTipo,
            tdcCodigo,
            dxcAno
        );
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TBDOCTOCXCDto dto)
    {
        var result = await _service.CreateAsync(dto);
        return result.Success == true
            ? StatusCode(201, result)
            : StatusCode(result.StatusCode, result);
    }

    [HttpPut(
        "{ciaCodigo:int}/{ofiCodigo:int}/{monCodigo:int}/{tdcTipo}/{tdcCodigo:int}/{dxcAno}"
    )]
    public async Task<IActionResult> Update(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno,
        [FromBody] TBDOCTOCXCDto dto
    )
    {
        var result = await _service.UpdateAsync(
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            tdcTipo,
            tdcCodigo,
            dxcAno,
            dto
        );
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpDelete(
        "{ciaCodigo:int}/{ofiCodigo:int}/{monCodigo:int}/{tdcTipo}/{tdcCodigo:int}/{dxcAno}"
    )]
    public async Task<IActionResult> Delete(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string tdcTipo,
        int tdcCodigo,
        string dxcAno
    )
    {
        var result = await _service.DeleteAsync(
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            tdcTipo,
            tdcCodigo,
            dxcAno
        );
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
