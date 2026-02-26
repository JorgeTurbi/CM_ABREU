namespace ApiCm.DTOs.CuentasPorCobrar;

public sealed class TBDETRECIBODto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdcTipo { get; set; }
    public int TdcCodigo { get; set; }
    public required string DxcAno { get; set; }
    public int CrcNumero { get; set; }
    public int DrcSecuencia { get; set; }
    public DateTime DrcFecha { get; set; }
    public required string DrcReferencia { get; set; }
    public string? DrcNcrNumero { get; set; }
    public decimal? DrcNcrValor { get; set; }
    public string? DrcDesctoTipo { get; set; }
    public decimal? DrcDesctoPorc { get; set; }
    public decimal? DrcDesctoValor { get; set; }
    public decimal DrcValor { get; set; }
    public decimal DrcBalance { get; set; }
    public bool DrcEstado { get; set; }
    public string? DrcNcf { get; set; }
    public string? DrcEcfNumero { get; set; }
    public required string DrcEcfEstado { get; set; }
    public int DrcFactura { get; set; }
    public int? DrcNcrFactura { get; set; }
}
