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
public class ConCteController : ControllerBase
{
    private readonly IConCteService _service;

    public ConCteController(IConCteService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationRequest pagination)
    {
        var result = await _service.GetAllAsync(pagination);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpGet("{ciaCodigo:int}/{cteCodigo}/{cclCodigo:int}")]
    public async Task<IActionResult> GetById(int ciaCodigo, string cteCodigo, int cclCodigo)
    {
        var result = await _service.GetByIdAsync(ciaCodigo, cteCodigo, cclCodigo);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TBCONCTEDto dto)
    {
        var result = await _service.CreateAsync(dto);
        return result.Success == true
            ? StatusCode(201, result)
            : StatusCode(result.StatusCode, result);
    }

    [HttpPut("{ciaCodigo:int}/{cteCodigo}/{cclCodigo:int}")]
    public async Task<IActionResult> Update(
        int ciaCodigo,
        string cteCodigo,
        int cclCodigo,
        [FromBody] TBCONCTEDto dto
    )
    {
        var result = await _service.UpdateAsync(ciaCodigo, cteCodigo, cclCodigo, dto);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
