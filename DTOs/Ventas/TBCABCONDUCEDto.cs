namespace ApiCm.DTOs.Ventas;

public sealed class TBCABCONDUCEDTO
{
    public long CcnInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdvTipo { get; set; }
    public int TdvCodigo { get; set; }
    public required string DnvAno { get; set; }
    public int CcnNumero { get; set; }
    public int CpgCodigo { get; set; }
    public int? TrpCodigo { get; set; }
    public int VenCodigo { get; set; }
    public int? LecCodigo { get; set; }
    public int? RepCodigo { get; set; }
    public int CcnCompania { get; set; }
    public required string CcnCteCodigo { get; set; }
    public string? CcnCteNombre { get; set; }
    public string? CcnCteDireccion { get; set; }
    public string? CcnCteTelefono { get; set; }
    public string? CcnCteCedulaRnc { get; set; }
    public DateTime CcnFecha { get; set; }
    public DateTime CcnProceso { get; set; }
    public int? CcnDias { get; set; }
    public string? CcnOrdenCte { get; set; }
    public decimal CcnDescPorc { get; set; }
    public bool CcnImpUsa { get; set; }
    public decimal? CcnImpPorc { get; set; }
    public decimal CcnValorBruto { get; set; }
    public decimal CcnValorDescuento { get; set; }
    public decimal CcnValorImpuesto { get; set; }
    public decimal CcnValorFlete { get; set; }
    public decimal CcnValorSeguro { get; set; }
    public decimal CcnValorOtro { get; set; }
    public decimal? CcnTasa { get; set; }
    public string? CcnNotaPie { get; set; }
    public string? CcnNota2 { get; set; }
    public string? CcnEntrgNombre { get; set; }
    public DateTime? CcnEntrgFecha { get; set; }
    public required string CcnElaboradoPor { get; set; }
    public required string CcnGenerado { get; set; }
    public bool CcnImpreso { get; set; }
    public bool CcnExportado { get; set; }
    public bool CcnCorreo { get; set; }
    public bool CcnPosteado { get; set; }
    public bool CcnNulo { get; set; }
    public bool CcnEstado { get; set; }
    public string? PryCodigo { get; set; }
    public decimal CcnValorPrp { get; set; }
    public decimal CcnValorCdt { get; set; }
    public decimal CcnValorIsc { get; set; }
    public decimal CcnValorEsp { get; set; }
    public decimal CcnValorAdv { get; set; }
}
