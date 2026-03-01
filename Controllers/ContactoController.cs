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
public class ContactoController : ControllerBase
{
    private readonly IContactoService _service;

    public ContactoController(IContactoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationRequest pagination)
    {
        var result = await _service.GetAllAsync(pagination);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpGet("{ciaCodigo:int}/{conCodigo:int}")]
    public async Task<IActionResult> GetById(int ciaCodigo, int conCodigo)
    {
        var result = await _service.GetByIdAsync(ciaCodigo, conCodigo);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TBCONTACTODto dto)
    {
        var result = await _service.CreateAsync(dto);
        return result.Success == true
            ? StatusCode(201, result)
            : StatusCode(result.StatusCode, result);
    }

    [HttpPut("{ciaCodigo:int}/{conCodigo:int}")]
    public async Task<IActionResult> Update(
        int ciaCodigo,
        int conCodigo,
        [FromBody] TBCONTACTODto dto
    )
    {
        var result = await _service.UpdateAsync(ciaCodigo, conCodigo, dto);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
