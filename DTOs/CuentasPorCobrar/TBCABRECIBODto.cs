namespace ApiCm.DTOs.CuentasPorCobrar;

public sealed class TBCABRECIBODto
{
    public long CrcInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdcTipo { get; set; }
    public int TdcCodigo { get; set; }
    public required string DxcAno { get; set; }
    public int CrcNumero { get; set; }
    public string? CteCodigo { get; set; }
    public int CrcCobCodigo { get; set; }
    public required string CajCodigo { get; set; }
    public int? BccCodigo { get; set; }
    public int? TarCodigo { get; set; }
    public bool CrcChequeDev { get; set; }
    public required string CrcTipoCrn { get; set; }
    public string? CrcConcepto { get; set; }
    public DateTime CrcFecha { get; set; }
    public DateTime CrcProceso { get; set; }
    public required string CrcElaboradoPor { get; set; }
    public string? CrcDocumento { get; set; }
    public string? CrcNombre { get; set; }
    public decimal CrcValor { get; set; }
    public decimal CrcComision { get; set; }
    public decimal? CrcTasa { get; set; }
    public string? CrcDpgoBco { get; set; }
    public string? CrcDpgoTpo { get; set; }
    public string? CrcDpgoAnm { get; set; }
    public int? CrcDpgoNum { get; set; }
    public decimal CrcChqValor { get; set; }
    public string? CrcChqNumero { get; set; }
    public string? CrcChqCuenta { get; set; }
    public decimal CrcEfeValor { get; set; }
    public decimal CrcDptValor { get; set; }
    public string? CrcDptNumero { get; set; }
    public decimal CrcCpnValor { get; set; }
    public decimal CrcNcrValor { get; set; }
    public decimal CrcTrjValor { get; set; }
    public string? CrcTrjAprob { get; set; }
    public decimal CrcPrmValor { get; set; }
    public int? CrcChqDiaEfect { get; set; }
    public bool CrcImpreso { get; set; }
    public bool CrcExportado { get; set; }
    public bool CrcCorreo { get; set; }
    public bool CrcPosteado { get; set; }
    public bool CrcNulo { get; set; }
    public bool CrcEstado { get; set; }
    public string? PryCodigo { get; set; }
    public string? CrcTrjNumero { get; set; }
}
