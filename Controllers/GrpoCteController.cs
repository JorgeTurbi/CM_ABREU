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
public class GrpoCteController : ControllerBase
{
    private readonly IGrpoCteService _service;

    public GrpoCteController(IGrpoCteService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationRequest pagination)
    {
        var result = await _service.GetAllAsync(pagination);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpGet("{ciaCodigo:int}/{gctCodigo:int}")]
    public async Task<IActionResult> GetById(int ciaCodigo, int gctCodigo)
    {
        var result = await _service.GetByIdAsync(ciaCodigo, gctCodigo);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TBGRPOCTEDto dto)
    {
        var result = await _service.CreateAsync(dto);
        return result.Success == true
            ? StatusCode(201, result)
            : StatusCode(result.StatusCode, result);
    }

    [HttpPut("{ciaCodigo:int}/{gctCodigo:int}")]
    public async Task<IActionResult> Update(
        int ciaCodigo,
        int gctCodigo,
        [FromBody] TBGRPOCTEDto dto
    )
    {
        var result = await _service.UpdateAsync(ciaCodigo, gctCodigo, dto);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpDelete("{ciaCodigo:int}/{gctCodigo:int}")]
    public async Task<IActionResult> Delete(int ciaCodigo, int gctCodigo)
    {
        var result = await _service.DeleteAsync(ciaCodigo, gctCodigo);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
