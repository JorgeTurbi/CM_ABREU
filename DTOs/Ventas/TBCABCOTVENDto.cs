namespace ApiCm.DTOs.Ventas;

public sealed class TBCABCOTVENDTO
{
    public long CcvInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdvTipo { get; set; }
    public int TdvCodigo { get; set; }
    public required string DnvAno { get; set; }
    public int CcvNumero { get; set; }
    public int? TenCodigo { get; set; }
    public int VenCodigo { get; set; }
    public int CpgCodigo { get; set; }
    public int CcvCompania { get; set; }
    public DateTime CcvFecha { get; set; }
    public DateTime CcvProceso { get; set; }
    public required string CcvCteCodigo { get; set; }
    public string? CcvCteNombre { get; set; }
    public string? CcvCteDireccion { get; set; }
    public string? CcvCteTelefono { get; set; }
    public string? CcvCteCedulaRnc { get; set; }
    public string? CcvOrdenCte { get; set; }
    public decimal CcvDescPorc { get; set; }
    public bool CcvImpUsa { get; set; }
    public decimal? CcvImpPorc { get; set; }
    public decimal CcvValorBruto { get; set; }
    public decimal CcvValorDescuento { get; set; }
    public decimal CcvValorImpuesto { get; set; }
    public decimal CcvValorFlete { get; set; }
    public decimal CcvValorSeguro { get; set; }
    public decimal CcvValorOtro { get; set; }
    public decimal? CcvTasa { get; set; }
    public string? CcvNotaPie { get; set; }
    public string? CcvNota2 { get; set; }
    public required string CcvElaboradoPor { get; set; }
    public required string CcvGenerado { get; set; }
    public bool CcvImpreso { get; set; }
    public bool CcvExportado { get; set; }
    public bool CcvCorreo { get; set; }
    public bool CcvPosteado { get; set; }
    public bool CcvNulo { get; set; }
    public bool CcvEstado { get; set; }
    public string? PryCodigo { get; set; }
    public decimal CcvValorPrp { get; set; }
    public decimal CcvValorCdt { get; set; }
    public decimal CcvValorIsc { get; set; }
    public decimal CcvValorEsp { get; set; }
    public decimal CcvValorAdv { get; set; }
}
