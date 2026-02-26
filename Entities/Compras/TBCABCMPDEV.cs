using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBCABCMPDEV")]
public class TBCABCMPDEV
{
    [Column("CCD_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CcdInternoNo { get; set; }

    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("TDM_TIPO")]
    public required string TdmTipo { get; set; }

    [Column("TDM_CODIGO")]
    public int TdmCodigo { get; set; }

    [Column("DCM_ANO")]
    public required string DcmAno { get; set; }

    [Column("CCD_NUMERO")]
    public int CcdNumero { get; set; }

    [Column("CCD_COMPANIA")]
    public int CcdCompania { get; set; }

    [Column("CPG_CODIGO")]
    public int CpgCodigo { get; set; }

    [Column("CCD_PRV_CODIGO")]
    public required string CcdPrvCodigo { get; set; }

    [Column("CCD_PRV_NOMBRE")]
    public string? CcdPrvNombre { get; set; }

    [Column("CCD_PRV_CEDULA_RNC")]
    public string? CcdPrvCedulaRnc { get; set; }

    [Column("CCD_FACTURA")]
    public required string CcdFactura { get; set; }

    [Column("CCD_NCF")]
    public string? CcdNcf { get; set; }

    [Column("CCD_COMPRA")]
    public string? CcdCompra { get; set; }

    [Column("CCD_FECHA")]
    public DateTime CcdFecha { get; set; }

    [Column("CCD_FECHA_FACTURA")]
    public DateTime? CcdFechaFactura { get; set; }

    [Column("CCD_FECHA_RECIBIDA")]
    public DateTime? CcdFechaRecibida { get; set; }

    [Column("CCD_TIPO_GASTO")]
    public int CcdTipoGasto { get; set; }

    [Column("CCD_TIPO_RETEN")]
    public int? CcdTipoReten { get; set; }

    [Column("CCD_FORMA_PAGO")]
    public int? CcdFormaPago { get; set; }

    [Column("CCD_IMP_PROPORC")]
    public decimal CcdImpProporc { get; set; }

    [Column("CCD_IMP_COSTO")]
    public decimal CcdImpCosto { get; set; }

    [Column("CCD_PROCESO")]
    public DateTime CcdProceso { get; set; }

    [Column("CCD_DESC_PORC")]
    public decimal CcdDescPorc { get; set; }

    [Column("CCD_TASA")]
    public decimal? CcdTasa { get; set; }

    [Column("CCD_IMP_USA")]
    public bool CcdImpUsa { get; set; }

    [Column("CCD_IMP_PORC")]
    public decimal? CcdImpPorc { get; set; }

    [Column("CCD_VALOR_BRUTO")]
    public decimal CcdValorBruto { get; set; }

    [Column("CCD_VALOR_DESCUENTO")]
    public decimal CcdValorDescuento { get; set; }

    [Column("CCD_VALOR_IMPUESTO")]
    public decimal CcdValorImpuesto { get; set; }

    [Column("CCD_VALOR_FLETE")]
    public decimal CcdValorFlete { get; set; }

    [Column("CCD_VALOR_SEGURO")]
    public decimal CcdValorSeguro { get; set; }

    [Column("CCD_VALOR_OTRO")]
    public decimal CcdValorOtro { get; set; }

    [Column("CCD_VALOR_RETISR")]
    public decimal CcdValorRetisr { get; set; }

    [Column("CCD_VALOR_RETITB")]
    public decimal CcdValorRetitb { get; set; }

    [Column("CCD_VALOR_PROPINA")]
    public decimal CcdValorPropina { get; set; }

    [Column("CCD_VALOR_ISC")]
    public decimal CcdValorIsc { get; set; }

    [Column("CCD_VALOR_OTRO_IMP")]
    public decimal CcdValorOtroImp { get; set; }

    [Column("CCD_VALOR_SERV")]
    public decimal CcdValorServ { get; set; }

    [Column("CCD_VALOR_BIEN")]
    public decimal CcdValorBien { get; set; }

    [Column("CCD_NOTA_PIE")]
    public string? CcdNotaPie { get; set; }

    [Column("CCD_PASA_CXP")]
    public bool CcdPasaCxp { get; set; }

    [Column("CCD_ELABORADO_POR")]
    public required string CcdElaboradoPor { get; set; }

    [Column("CCD_GENERADO")]
    public required string CcdGenerado { get; set; }

    [Column("CCD_IMPRESO")]
    public bool CcdImpreso { get; set; }

    [Column("CCD_EXPORTADO")]
    public bool CcdExportado { get; set; }

    [Column("CCD_CORREO")]
    public bool CcdCorreo { get; set; }

    [Column("CCD_POSTEADO")]
    public bool CcdPosteado { get; set; }

    [Column("CCD_NULO")]
    public bool CcdNulo { get; set; }

    [Column("CCD_ESTADO")]
    public bool CcdEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }

    [Column("CCD_LIQ_MON")]
    public int? CcdLiqMon { get; set; }

    [Column("CCD_LIQ_TPO")]
    public string? CcdLiqTpo { get; set; }

    [Column("CCD_LIQ_COD")]
    public int? CcdLiqCod { get; set; }

    [Column("CCD_LIQ_ANO")]
    public string? CcdLiqAno { get; set; }

    [Column("CCD_LIQ_NUM")]
    public int? CcdLiqNum { get; set; }

    [Column("CCD_ECF_NUMERO")]
    public string? CcdEcfNumero { get; set; }

    [Column("CCD_ECF_ESTADO")]
    public required string CcdEcfEstado { get; set; }

    [Column("CCD_AJUSTE_BRUTO")]
    public decimal CcdAjusteBruto { get; set; }

    [Column("CCD_AJUSTE_DESCTO")]
    public decimal CcdAjusteDescto { get; set; }

    [Column("CCD_AJUSTE_IMPUESTO")]
    public decimal CcdAjusteImpuesto { get; set; }
}
