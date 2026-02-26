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
public class CxcHisController : ControllerBase
{
    private readonly ICxcHisService _service;

    public CxcHisController(ICxcHisService service)
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
        "{ciaCodigo:int}/{ofiCodigo:int}/{monCodigo:int}/{cchModulo}/{cchTipo}/{cchCodigo:int}/{cchAno}/{cchNumero:int}/{cchSecuencia:int}/{cchSubsec:int}"
    )]
    public async Task<IActionResult> GetById(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string cchModulo,
        string cchTipo,
        int cchCodigo,
        string cchAno,
        int cchNumero,
        int cchSecuencia,
        int cchSubsec
    )
    {
        var result = await _service.GetByIdAsync(
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            cchModulo,
            cchTipo,
            cchCodigo,
            cchAno,
            cchNumero,
            cchSecuencia,
            cchSubsec
        );
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TBCXCHISDto dto)
    {
        var result = await _service.CreateAsync(dto);
        return result.Success == true
            ? StatusCode(201, result)
            : StatusCode(result.StatusCode, result);
    }

    [HttpPut(
        "{ciaCodigo:int}/{ofiCodigo:int}/{monCodigo:int}/{cchModulo}/{cchTipo}/{cchCodigo:int}/{cchAno}/{cchNumero:int}/{cchSecuencia:int}/{cchSubsec:int}"
    )]
    public async Task<IActionResult> Update(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string cchModulo,
        string cchTipo,
        int cchCodigo,
        string cchAno,
        int cchNumero,
        int cchSecuencia,
        int cchSubsec,
        [FromBody] TBCXCHISDto dto
    )
    {
        var result = await _service.UpdateAsync(
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            cchModulo,
            cchTipo,
            cchCodigo,
            cchAno,
            cchNumero,
            cchSecuencia,
            cchSubsec,
            dto
        );
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpDelete(
        "{ciaCodigo:int}/{ofiCodigo:int}/{monCodigo:int}/{cchModulo}/{cchTipo}/{cchCodigo:int}/{cchAno}/{cchNumero:int}/{cchSecuencia:int}/{cchSubsec:int}"
    )]
    public async Task<IActionResult> Delete(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string cchModulo,
        string cchTipo,
        int cchCodigo,
        string cchAno,
        int cchNumero,
        int cchSecuencia,
        int cchSubsec
    )
    {
        var result = await _service.DeleteAsync(
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            cchModulo,
            cchTipo,
            cchCodigo,
            cchAno,
            cchNumero,
            cchSecuencia,
            cchSubsec
        );
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
