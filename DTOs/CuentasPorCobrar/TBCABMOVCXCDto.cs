namespace ApiCm.DTOs.CuentasPorCobrar;

public sealed class TBCABMOVCXCDto
{
    public long CmcInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdcTipo { get; set; }
    public int TdcCodigo { get; set; }
    public required string DxcAno { get; set; }
    public int CmcNumero { get; set; }
    public required string CteCodigo { get; set; }
    public int VenCodigo { get; set; }
    public int? CpgCodigo { get; set; }
    public string? CmcNcf { get; set; }
    public string? CmcConcepto { get; set; }
    public string? CmcDocumento { get; set; }
    public DateTime CmcFecha { get; set; }
    public DateTime CmcProceso { get; set; }
    public required string CmcElaboradoPor { get; set; }
    public decimal CmcValor { get; set; }
    public decimal CmcImpuesto { get; set; }
    public decimal CmcComision { get; set; }
    public decimal? CmcTasa { get; set; }
    public bool CmcImpreso { get; set; }
    public bool CmcExportado { get; set; }
    public bool CmcCorreo { get; set; }
    public bool CmcPosteado { get; set; }
    public bool CmcNulo { get; set; }
    public bool CmcEstado { get; set; }
    public string? PryCodigo { get; set; }
    public string? CmcEcfNumero { get; set; }
    public required string CmcEcfEstado { get; set; }
    public int CmcTipoIngreso { get; set; }
    public int? CmcFormaPago { get; set; }
}
