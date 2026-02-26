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
public class ClienteController : ControllerBase
{
    private readonly IClienteService _service;

    public ClienteController(IClienteService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationRequest pagination)
    {
        var result = await _service.GetAllAsync(pagination);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpGet("{ciaCodigo:int}/{cteCodigo}")]
    public async Task<IActionResult> GetById(int ciaCodigo, string cteCodigo)
    {
        var result = await _service.GetByIdAsync(ciaCodigo, cteCodigo);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TBCLIENTEDto dto)
    {
        var result = await _service.CreateAsync(dto);
        return result.Success == true
            ? StatusCode(201, result)
            : StatusCode(result.StatusCode, result);
    }

    [HttpPut("{ciaCodigo:int}/{cteCodigo}")]
    public async Task<IActionResult> Update(
        int ciaCodigo,
        string cteCodigo,
        [FromBody] TBCLIENTEDto dto
    )
    {
        var result = await _service.UpdateAsync(ciaCodigo, cteCodigo, dto);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpDelete("{ciaCodigo:int}/{cteCodigo}")]
    public async Task<IActionResult> Delete(int ciaCodigo, string cteCodigo)
    {
        var result = await _service.DeleteAsync(ciaCodigo, cteCodigo);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
