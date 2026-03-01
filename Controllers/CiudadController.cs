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
public class CiudadController : ControllerBase
{
    private readonly ICiudadService _service;

    public CiudadController(ICiudadService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationRequest pagination)
    {
        var result = await _service.GetAllAsync(pagination);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpGet("{cdaCodigo:int}")]
    public async Task<IActionResult> GetById(int cdaCodigo)
    {
        var result = await _service.GetByIdAsync(cdaCodigo);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TBCIUDADDto dto)
    {
        var result = await _service.CreateAsync(dto);
        return result.Success == true
            ? StatusCode(201, result)
            : StatusCode(result.StatusCode, result);
    }

    [HttpPut("{cdaCodigo:int}")]
    public async Task<IActionResult> Update(int cdaCodigo, [FromBody] TBCIUDADDto dto)
    {
        var result = await _service.UpdateAsync(cdaCodigo, dto);
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
