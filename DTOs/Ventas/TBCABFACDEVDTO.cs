namespace ApiCm.DTOs.Ventas;

public sealed class TBCABFACDEVDTO
{
    public long CfdInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdvTipo { get; set; }
    public int TdvCodigo { get; set; }
    public required string DnvAno { get; set; }
    public int CfdNumero { get; set; }
    public int CfdCompania { get; set; }
    public int? TrpCodigo { get; set; }
    public int? TarCodigo { get; set; }
    public int? BccCodigo { get; set; }
    public int CpgCodigo { get; set; }
    public int VenCodigo { get; set; }
    public required string CajCodigo { get; set; }
    public int? LecCodigo { get; set; }
    public int? RepCodigo { get; set; }
    public int? CjaCodigo { get; set; }
    public string? CfdNcf { get; set; }
    public string? CfdNif { get; set; }
    public DateTime CfdFecha { get; set; }
    public DateTime CfdProceso { get; set; }
    public string? CfdOrden { get; set; }
    public DateTime? CfdOrdenFch { get; set; }
    public string? CfdDocumento { get; set; }
    public required string CfdCteCodigo { get; set; }
    public string? CfdCteNombre { get; set; }
    public string? CfdCteDireccion { get; set; }
    public string? CfdCteTelefono { get; set; }
    public string? CfdCteCedulaRnc { get; set; }
    public int? CfdDiasCredito { get; set; }
    public int CfdTipoIngreso { get; set; }
    public decimal CfdDescPorc { get; set; }
    public bool CfdImpUsa { get; set; }
    public decimal? CfdImpPorc { get; set; }
    public decimal CfdComision { get; set; }
    public decimal? CfdTasa { get; set; }
    public decimal CfdValorBruto { get; set; }
    public decimal CfdValorDescuento { get; set; }
    public decimal CfdValorImpuesto { get; set; }
    public decimal CfdValorFlete { get; set; }
    public decimal CfdValorSeguro { get; set; }
    public decimal CfdValorOtro { get; set; }
    public decimal CfdValorAdv { get; set; }
    public decimal CfdValorEsp { get; set; }
    public string? CfdDpgoBco { get; set; }
    public string? CfdDpgoTpo { get; set; }
    public string? CfdDpgoAnm { get; set; }
    public int? CfdDpgoNum { get; set; }
    public string? CfdComboTpo { get; set; }
    public int? CfdComboCod { get; set; }
    public int? CfdComboNum { get; set; }
    public string? CfdCreditoTpo { get; set; }
    public int? CfdCreditoCod { get; set; }
    public string? CfdCreditoAno { get; set; }
    public int? CfdCreditoNum { get; set; }
    public decimal CfdEfeValor { get; set; }
    public decimal CfdDptValor { get; set; }
    public string? CfdDptNumero { get; set; }
    public decimal CfdCpnValor { get; set; }
    public decimal CfdNcrValor { get; set; }
    public decimal CfdCrdValor { get; set; }
    public string? CfdChqCuenta { get; set; }
    public string? CfdChqNumero { get; set; }
    public decimal CfdChqValor { get; set; }
    public string? CfdTrjAprob { get; set; }
    public decimal CfdTrjValor { get; set; }
    public decimal CfdPrmValor { get; set; }
    public string? CfdFormaDev { get; set; }
    public bool CfdTemporal { get; set; }
    public bool CfdDomicilio { get; set; }
    public string? CfdEntregaNombre { get; set; }
    public DateTime? CfdEntregaFecha { get; set; }
    public string? CfdNotaPie { get; set; }
    public string? CfdNota2 { get; set; }
    public required string CfdElaboradoPor { get; set; }
    public required string CfdGenerado { get; set; }
    public bool CfdImpreso { get; set; }
    public bool CfdExportado { get; set; }
    public bool CfdCorreo { get; set; }
    public bool CfdPosteado { get; set; }
    public bool CfdNulo { get; set; }
    public bool CfdEstado { get; set; }
    public decimal CfdValorRetisr { get; set; }
    public decimal CfdValorRetitb { get; set; }
    public string? PryCodigo { get; set; }
    public string? CfdTrjNumero { get; set; }
    public string? CfdEcfNumero { get; set; }
    public required string CfdEcfEstado { get; set; }
    public decimal CfdValorPrp { get; set; }
    public decimal CfdValorCdt { get; set; }
    public decimal CfdValorIsc { get; set; }
    public int CfdFactura { get; set; }
    public int? CfdFormaPago { get; set; }
}
