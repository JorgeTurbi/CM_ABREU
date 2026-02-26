namespace ApiCm.DTOs.CuentasPorCobrar;

public sealed class TBCXCACTDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string CcaModulo { get; set; }
    public required string CcaTipo { get; set; }
    public int CcaCodigo { get; set; }
    public required string CcaAno { get; set; }
    public int CcaNumero { get; set; }
    public int CcaSecuencia { get; set; }
    public int CcaSubsec { get; set; }
    public required string CteCodigo { get; set; }
    public int VenCodigo { get; set; }
    public int CcaOficina { get; set; }
    public int CcaCobrador { get; set; }
    public required string CcaRefTipo { get; set; }
    public required string CcaRefNumero { get; set; }
    public required string CcaOrden { get; set; }
    public string? CcaNcf { get; set; }
    public string? CcaDoctoManual { get; set; }
    public DateTime CcaFecha { get; set; }
    public DateTime? CcaFechaVence { get; set; }
    public int? CcaDiaEfectividad { get; set; }
    public decimal CcaValor { get; set; }
    public decimal CcaImpuesto { get; set; }
    public int CcaEfecto { get; set; }
    public decimal? CcaTasa { get; set; }
    public bool CcaReciboChkDev { get; set; }
    public bool CcaEstado { get; set; }
    public string? PryCodigo { get; set; }
    public int CcaFactura { get; set; }
}
