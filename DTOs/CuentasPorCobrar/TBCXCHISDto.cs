namespace ApiCm.DTOs.CuentasPorCobrar;

public sealed class TBCXCHISDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string CchModulo { get; set; }
    public required string CchTipo { get; set; }
    public int CchCodigo { get; set; }
    public required string CchAno { get; set; }
    public int CchNumero { get; set; }
    public int CchSecuencia { get; set; }
    public int CchSubsec { get; set; }
    public required string CteCodigo { get; set; }
    public int VenCodigo { get; set; }
    public int CchOficina { get; set; }
    public int CchCobrador { get; set; }
    public required string CchRefTipo { get; set; }
    public required string CchRefNumero { get; set; }
    public required string CchOrden { get; set; }
    public string? CchNcf { get; set; }
    public string? CchDoctoManual { get; set; }
    public DateTime CchFecha { get; set; }
    public DateTime? CchFechaVence { get; set; }
    public int? CchDiaEfectividad { get; set; }
    public decimal CchValor { get; set; }
    public decimal CchImpuesto { get; set; }
    public int CchEfecto { get; set; }
    public decimal? CchTasa { get; set; }
    public bool CchReciboChkDev { get; set; }
    public bool CchEstado { get; set; }
    public string? PryCodigo { get; set; }
    public int CchFactura { get; set; }
}
