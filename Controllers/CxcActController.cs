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
public class CxcActController : ControllerBase
{
    private readonly ICxcActService _service;

    public CxcActController(ICxcActService service)
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
        "{ciaCodigo:int}/{ofiCodigo:int}/{monCodigo:int}/{ccaModulo}/{ccaTipo}/{ccaCodigo:int}/{ccaAno}/{ccaNumero:int}/{ccaSecuencia:int}/{ccaSubsec:int}"
    )]
    public async Task<IActionResult> GetById(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string ccaModulo,
        string ccaTipo,
        int ccaCodigo,
        string ccaAno,
        int ccaNumero,
        int ccaSecuencia,
        int ccaSubsec
    )
    {
        var result = await _service.GetByIdAsync(
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            ccaModulo,
            ccaTipo,
            ccaCodigo,
            ccaAno,
            ccaNumero,
            ccaSecuencia,
            ccaSubsec
        );
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TBCXCACTDto dto)
    {
        var result = await _service.CreateAsync(dto);
        return result.Success == true
            ? StatusCode(201, result)
            : StatusCode(result.StatusCode, result);
    }

    [HttpPut(
        "{ciaCodigo:int}/{ofiCodigo:int}/{monCodigo:int}/{ccaModulo}/{ccaTipo}/{ccaCodigo:int}/{ccaAno}/{ccaNumero:int}/{ccaSecuencia:int}/{ccaSubsec:int}"
    )]
    public async Task<IActionResult> Update(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string ccaModulo,
        string ccaTipo,
        int ccaCodigo,
        string ccaAno,
        int ccaNumero,
        int ccaSecuencia,
        int ccaSubsec,
        [FromBody] TBCXCACTDto dto
    )
    {
        var result = await _service.UpdateAsync(
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            ccaModulo,
            ccaTipo,
            ccaCodigo,
            ccaAno,
            ccaNumero,
            ccaSecuencia,
            ccaSubsec,
            dto
        );
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }

    [HttpDelete(
        "{ciaCodigo:int}/{ofiCodigo:int}/{monCodigo:int}/{ccaModulo}/{ccaTipo}/{ccaCodigo:int}/{ccaAno}/{ccaNumero:int}/{ccaSecuencia:int}/{ccaSubsec:int}"
    )]
    public async Task<IActionResult> Delete(
        int ciaCodigo,
        int ofiCodigo,
        int monCodigo,
        string ccaModulo,
        string ccaTipo,
        int ccaCodigo,
        string ccaAno,
        int ccaNumero,
        int ccaSecuencia,
        int ccaSubsec
    )
    {
        var result = await _service.DeleteAsync(
            ciaCodigo,
            ofiCodigo,
            monCodigo,
            ccaModulo,
            ccaTipo,
            ccaCodigo,
            ccaAno,
            ccaNumero,
            ccaSecuencia,
            ccaSubsec
        );
        return result.Success == true ? Ok(result) : StatusCode(result.StatusCode, result);
    }
}
