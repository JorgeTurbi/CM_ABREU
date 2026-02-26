namespace ApiCm.DTOs.Compras;

public sealed class TBCABCMPDEVDto
{
    public long CcdInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int CcdNumero { get; set; }
    public int CcdCompania { get; set; }
    public int CpgCodigo { get; set; }
    public required string CcdPrvCodigo { get; set; }
    public string? CcdPrvNombre { get; set; }
    public string? CcdPrvCedulaRnc { get; set; }
    public required string CcdFactura { get; set; }
    public string? CcdNcf { get; set; }
    public string? CcdCompra { get; set; }
    public DateTime CcdFecha { get; set; }
    public DateTime? CcdFechaFactura { get; set; }
    public DateTime? CcdFechaRecibida { get; set; }
    public int CcdTipoGasto { get; set; }
    public int? CcdTipoReten { get; set; }
    public int? CcdFormaPago { get; set; }
    public decimal CcdImpProporc { get; set; }
    public decimal CcdImpCosto { get; set; }
    public DateTime CcdProceso { get; set; }
    public decimal CcdDescPorc { get; set; }
    public decimal? CcdTasa { get; set; }
    public bool CcdImpUsa { get; set; }
    public decimal? CcdImpPorc { get; set; }
    public decimal CcdValorBruto { get; set; }
    public decimal CcdValorDescuento { get; set; }
    public decimal CcdValorImpuesto { get; set; }
    public decimal CcdValorFlete { get; set; }
    public decimal CcdValorSeguro { get; set; }
    public decimal CcdValorOtro { get; set; }
    public decimal CcdValorRetisr { get; set; }
    public decimal CcdValorRetitb { get; set; }
    public decimal CcdValorPropina { get; set; }
    public decimal CcdValorIsc { get; set; }
    public decimal CcdValorOtroImp { get; set; }
    public decimal CcdValorServ { get; set; }
    public decimal CcdValorBien { get; set; }
    public string? CcdNotaPie { get; set; }
    public bool CcdPasaCxp { get; set; }
    public required string CcdElaboradoPor { get; set; }
    public required string CcdGenerado { get; set; }
    public bool CcdImpreso { get; set; }
    public bool CcdExportado { get; set; }
    public bool CcdCorreo { get; set; }
    public bool CcdPosteado { get; set; }
    public bool CcdNulo { get; set; }
    public bool CcdEstado { get; set; }
    public string? PryCodigo { get; set; }
    public int? CcdLiqMon { get; set; }
    public string? CcdLiqTpo { get; set; }
    public int? CcdLiqCod { get; set; }
    public string? CcdLiqAno { get; set; }
    public int? CcdLiqNum { get; set; }
    public string? CcdEcfNumero { get; set; }
    public required string CcdEcfEstado { get; set; }
    public decimal CcdAjusteBruto { get; set; }
    public decimal CcdAjusteDescto { get; set; }
    public decimal CcdAjusteImpuesto { get; set; }
}
