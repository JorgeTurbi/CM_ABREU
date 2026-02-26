namespace ApiCm.DTOs.Ventas;

public sealed class TBCABPEDIDODTO
{
    public long CpeInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdvTipo { get; set; }
    public int TdvCodigo { get; set; }
    public required string DnvAno { get; set; }
    public int CpeNumero { get; set; }
    public int VenCodigo { get; set; }
    public int CpgCodigo { get; set; }
    public int? LecCodigo { get; set; }
    public int CpeCompania { get; set; }
    public required string CpeCteCodigo { get; set; }
    public string? CpeCteNombre { get; set; }
    public string? CpeCteDireccion { get; set; }
    public string? CpeCteTelefono { get; set; }
    public string? CpeCteCedulaRnc { get; set; }
    public DateTime CpeFecha { get; set; }
    public DateTime? CpeFechaEntrega { get; set; }
    public DateTime CpeProceso { get; set; }
    public string? CpeOrdenCte { get; set; }
    public decimal CpeDescPorc { get; set; }
    public bool CpeImpUsa { get; set; }
    public decimal? CpeImpPorc { get; set; }
    public decimal CpeValorBruto { get; set; }
    public decimal CpeValorDescuento { get; set; }
    public decimal CpeValorImpuesto { get; set; }
    public decimal CpeValorFlete { get; set; }
    public decimal CpeValorSeguro { get; set; }
    public decimal CpeValorOtro { get; set; }
    public decimal? CpeTasa { get; set; }
    public string? CpeNotaPie { get; set; }
    public string? CpeNota2 { get; set; }
    public required string CpeEstadoPedido { get; set; }
    public required string CpeElaboradoPor { get; set; }
    public required string CpeGenerado { get; set; }
    public bool CpeImpreso { get; set; }
    public bool CpeExportado { get; set; }
    public bool CpeCorreo { get; set; }
    public bool CpePosteado { get; set; }
    public bool CpeNulo { get; set; }
    public bool CpeEstado { get; set; }
    public bool CpeAprobado { get; set; }
    public string? PryCodigo { get; set; }
    public decimal CpeValorPrp { get; set; }
    public decimal CpeValorCdt { get; set; }
    public decimal CpeValorIsc { get; set; }
    public decimal CpeValorEsp { get; set; }
    public decimal CpeValorAdv { get; set; }
    public int? TrpCodigo { get; set; }
    public int? RepCodigo { get; set; }
    public string? CpeEntrgNombre { get; set; }
    public DateTime? CpeEntrgFecha { get; set; }
}
