namespace ApiCm.DTOs.CuentasPorCobrar;

public sealed class TBTIPODOCCXCDto
{
    public int CiaCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdcTipo { get; set; }
    public int TdcCodigo { get; set; }
    public int? TncCodigo { get; set; }
    public required string TdcNombre { get; set; }
    public required string TdcSimbolo { get; set; }
    public required string TdcTipoSec { get; set; }
    public string? TdcFormatoImp { get; set; }
    public string? TdcCodigoEd { get; set; }
    public string? TdcCtaDocto { get; set; }
    public string? TdcCtaImp { get; set; }
    public string? TdcCtaDesc { get; set; }
    public string? TdcCtaRetItbis { get; set; }
    public string? TdcCtaRetEstado { get; set; }
    public string? TdcCtaComis { get; set; }
    public string? TdcCtaEfectivo { get; set; }
    public string? TdcCtaTarjeta { get; set; }
    public string? TdcCtaCheque { get; set; }
    public string? TdcCtaDeposito { get; set; }
    public string? TdcCtaNcredito { get; set; }
    public string? TdcCtaCupon { get; set; }
    public string? TdcCtaPermuta { get; set; }
    public bool TdcEstado { get; set; }
}
