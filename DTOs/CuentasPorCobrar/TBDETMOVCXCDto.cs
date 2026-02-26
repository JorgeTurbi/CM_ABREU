namespace ApiCm.DTOs.CuentasPorCobrar;

public sealed class TBDETMOVCXCDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdcTipo { get; set; }
    public int TdcCodigo { get; set; }
    public required string DxcAno { get; set; }
    public int CmcNumero { get; set; }
    public int DmcSecuencia { get; set; }
    public DateTime DmcFecha { get; set; }
    public required string DmcReferencia { get; set; }
    public decimal DmcValor { get; set; }
    public decimal DmcImpuesto { get; set; }
    public bool DmcEstado { get; set; }
    public int DmcFactura { get; set; }
}
