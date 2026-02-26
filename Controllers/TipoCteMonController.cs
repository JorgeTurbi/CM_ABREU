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
public class TipoCteMonController : ControllerBase
{
    private readonly ITipoCteMonService _service;

    public TipoCteMonController(ITipoCteMonService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationRequest pagination)
    {
        var result = await _service.GetAllAsync(pagination);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpGet("{ciaCodigo:int}/{tclCodigo:int}/{monCodigo:int}")]
    public async Task<IActionResult> GetById(int ciaCodigo, int tclCodigo, int monCodigo)
    {
        var result = await _service.GetByIdAsync(ciaCodigo, tclCodigo, monCodigo);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TBTIPOCTEMONDto dto)
    {
        var result = await _service.CreateAsync(dto);
        return result.Success == true
            ? StatusCode(201, result)
            : StatusCode(result.StatusCode, result);
    }

    [HttpPut("{ciaCodigo:int}/{tclCodigo:int}/{monCodigo:int}")]
    public async Task<IActionResult> Update(
        int ciaCodigo,
        int tclCodigo,
        int monCodigo,
        [FromBody] TBTIPOCTEMONDto dto
    )
    {
        var result = await _service.UpdateAsync(ciaCodigo, tclCodigo, monCodigo, dto);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpDelete("{ciaCodigo:int}/{tclCodigo:int}/{monCodigo:int}")]
    public async Task<IActionResult> Delete(int ciaCodigo, int tclCodigo, int monCodigo)
    {
        var result = await _service.DeleteAsync(ciaCodigo, tclCodigo, monCodigo);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
