using ApiCm.Commons.Pagination;
using ApiCm.DTOs.Clientes;
using ApiCm.Services.Interfaces.Clientes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiCm.Controllers;

[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName = "Clientes")]
[Authorize]
public class CteDefectoController : ControllerBase
{
    private readonly ICteDefectoService _service;

    public CteDefectoController(ICteDefectoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationRequest pagination)
    {
        var result = await _service.GetAllAsync(pagination);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpGet("{ciaCodigo:int}/{cdfLocalExterior}")]
    public async Task<IActionResult> GetById(int ciaCodigo, string cdfLocalExterior)
    {
        var result = await _service.GetByIdAsync(ciaCodigo, cdfLocalExterior);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TBCTEDEFECTODto dto)
    {
        var result = await _service.CreateAsync(dto);
        return result.Success == true
            ? StatusCode(201, result)
            : StatusCode(result.StatusCode, result);
    }

    [HttpPut("{ciaCodigo:int}/{cdfLocalExterior}")]
    public async Task<IActionResult> Update(
        int ciaCodigo,
        string cdfLocalExterior,
        [FromBody] TBCTEDEFECTODto dto
    )
    {
        var result = await _service.UpdateAsync(ciaCodigo, cdfLocalExterior, dto);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpDelete("{ciaCodigo:int}/{cdfLocalExterior}")]
    public async Task<IActionResult> Delete(int ciaCodigo, string cdfLocalExterior)
    {
        var result = await _service.DeleteAsync(ciaCodigo, cdfLocalExterior);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
