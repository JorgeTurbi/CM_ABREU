using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBCABFACDEV")]
public class TBCABFACDEV
{
    [Column("CFD_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CfdInternoNo { get; set; }

    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("TDV_TIPO")]
    public required string TdvTipo { get; set; }

    [Column("TDV_CODIGO")]
    public int TdvCodigo { get; set; }

    [Column("DNV_ANO")]
    public required string DnvAno { get; set; }

    [Column("CFD_NUMERO")]
    public int CfdNumero { get; set; }

    [Column("CFD_COMPANIA")]
    public int CfdCompania { get; set; }

    [Column("TRP_CODIGO")]
    public int? TrpCodigo { get; set; }

    [Column("TAR_CODIGO")]
    public int? TarCodigo { get; set; }

    [Column("BCC_CODIGO")]
    public int? BccCodigo { get; set; }

    [Column("CPG_CODIGO")]
    public int CpgCodigo { get; set; }

    [Column("VEN_CODIGO")]
    public int VenCodigo { get; set; }

    [Column("CAJ_CODIGO")]
    public required string CajCodigo { get; set; }

    [Column("LEC_CODIGO")]
    public int? LecCodigo { get; set; }

    [Column("REP_CODIGO")]
    public int? RepCodigo { get; set; }

    [Column("CJA_CODIGO")]
    public int? CjaCodigo { get; set; }

    [Column("CFD_NCF")]
    public string? CfdNcf { get; set; }

    [Column("CFD_NIF")]
    public string? CfdNif { get; set; }

    [Column("CFD_FECHA")]
    public DateTime CfdFecha { get; set; }

    [Column("CFD_PROCESO")]
    public DateTime CfdProceso { get; set; }

    [Column("CFD_ORDEN")]
    public string? CfdOrden { get; set; }

    [Column("CFD_ORDEN_FCH")]
    public DateTime? CfdOrdenFch { get; set; }

    [Column("CFD_DOCUMENTO")]
    public string? CfdDocumento { get; set; }

    [Column("CFD_CTE_CODIGO")]
    public required string CfdCteCodigo { get; set; }

    [Column("CFD_CTE_NOMBRE")]
    public string? CfdCteNombre { get; set; }

    [Column("CFD_CTE_DIRECCION")]
    public string? CfdCteDireccion { get; set; }

    [Column("CFD_CTE_TELEFONO")]
    public string? CfdCteTelefono { get; set; }

    [Column("CFD_CTE_CEDULA_RNC")]
    public string? CfdCteCedulaRnc { get; set; }

    [Column("CFD_DIAS_CREDITO")]
    public int? CfdDiasCredito { get; set; }

    [Column("CFD_TIPO_INGRESO")]
    public int CfdTipoIngreso { get; set; }

    [Column("CFD_DESC_PORC")]
    public decimal CfdDescPorc { get; set; }

    [Column("CFD_IMP_USA")]
    public bool CfdImpUsa { get; set; }

    [Column("CFD_IMP_PORC")]
    public decimal? CfdImpPorc { get; set; }

    [Column("CFD_COMISION")]
    public decimal CfdComision { get; set; }

    [Column("CFD_TASA")]
    public decimal? CfdTasa { get; set; }

    [Column("CFD_VALOR_BRUTO")]
    public decimal CfdValorBruto { get; set; }

    [Column("CFD_VALOR_DESCUENTO")]
    public decimal CfdValorDescuento { get; set; }

    [Column("CFD_VALOR_IMPUESTO")]
    public decimal CfdValorImpuesto { get; set; }

    [Column("CFD_VALOR_FLETE")]
    public decimal CfdValorFlete { get; set; }

    [Column("CFD_VALOR_SEGURO")]
    public decimal CfdValorSeguro { get; set; }

    [Column("CFD_VALOR_OTRO")]
    public decimal CfdValorOtro { get; set; }

    [Column("CFD_VALOR_ADV")]
    public decimal CfdValorAdv { get; set; }

    [Column("CFD_VALOR_ESP")]
    public decimal CfdValorEsp { get; set; }

    [Column("CFD_DPGO_BCO")]
    public string? CfdDpgoBco { get; set; }

    [Column("CFD_DPGO_TPO")]
    public string? CfdDpgoTpo { get; set; }

    [Column("CFD_DPGO_ANM")]
    public string? CfdDpgoAnm { get; set; }

    [Column("CFD_DPGO_NUM")]
    public int? CfdDpgoNum { get; set; }

    [Column("CFD_COMBO_TPO")]
    public string? CfdComboTpo { get; set; }

    [Column("CFD_COMBO_COD")]
    public int? CfdComboCod { get; set; }

    [Column("CFD_COMBO_NUM")]
    public int? CfdComboNum { get; set; }

    [Column("CFD_CREDITO_TPO")]
    public string? CfdCreditoTpo { get; set; }

    [Column("CFD_CREDITO_COD")]
    public int? CfdCreditoCod { get; set; }

    [Column("CFD_CREDITO_ANO")]
    public string? CfdCreditoAno { get; set; }

    [Column("CFD_CREDITO_NUM")]
    public int? CfdCreditoNum { get; set; }

    [Column("CFD_EFE_VALOR")]
    public decimal CfdEfeValor { get; set; }

    [Column("CFD_DPT_VALOR")]
    public decimal CfdDptValor { get; set; }

    [Column("CFD_DPT_NUMERO")]
    public string? CfdDptNumero { get; set; }

    [Column("CFD_CPN_VALOR")]
    public decimal CfdCpnValor { get; set; }

    [Column("CFD_NCR_VALOR")]
    public decimal CfdNcrValor { get; set; }

    [Column("CFD_CRD_VALOR")]
    public decimal CfdCrdValor { get; set; }

    [Column("CFD_CHQ_CUENTA")]
    public string? CfdChqCuenta { get; set; }

    [Column("CFD_CHQ_NUMERO")]
    public string? CfdChqNumero { get; set; }

    [Column("CFD_CHQ_VALOR")]
    public decimal CfdChqValor { get; set; }

    [Column("CFD_TRJ_APROB")]
    public string? CfdTrjAprob { get; set; }

    [Column("CFD_TRJ_VALOR")]
    public decimal CfdTrjValor { get; set; }

    [Column("CFD_PRM_VALOR")]
    public decimal CfdPrmValor { get; set; }

    [Column("CFD_FORMA_DEV")]
    public string? CfdFormaDev { get; set; }

    [Column("CFD_TEMPORAL")]
    public bool CfdTemporal { get; set; }

    [Column("CFD_DOMICILIO")]
    public bool CfdDomicilio { get; set; }

    [Column("CFD_ENTREGA_NOMBRE")]
    public string? CfdEntregaNombre { get; set; }

    [Column("CFD_ENTREGA_FECHA")]
    public DateTime? CfdEntregaFecha { get; set; }

    [Column("CFD_NOTA_PIE")]
    public string? CfdNotaPie { get; set; }

    [Column("CFD_NOTA_2")]
    public string? CfdNota2 { get; set; }

    [Column("CFD_ELABORADO_POR")]
    public required string CfdElaboradoPor { get; set; }

    [Column("CFD_GENERADO")]
    public required string CfdGenerado { get; set; }

    [Column("CFD_IMPRESO")]
    public bool CfdImpreso { get; set; }

    [Column("CFD_EXPORTADO")]
    public bool CfdExportado { get; set; }

    [Column("CFD_CORREO")]
    public bool CfdCorreo { get; set; }

    [Column("CFD_POSTEADO")]
    public bool CfdPosteado { get; set; }

    [Column("CFD_NULO")]
    public bool CfdNulo { get; set; }

    [Column("CFD_ESTADO")]
    public bool CfdEstado { get; set; }

    [Column("CFD_VALOR_RETISR")]
    public decimal CfdValorRetisr { get; set; }

    [Column("CFD_VALOR_RETITB")]
    public decimal CfdValorRetitb { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }

    [Column("CFD_TRJ_NUMERO")]
    public string? CfdTrjNumero { get; set; }

    [Column("CFD_ECF_NUMERO")]
    public string? CfdEcfNumero { get; set; }

    [Column("CFD_ECF_ESTADO")]
    public required string CfdEcfEstado { get; set; }

    [Column("CFD_VALOR_PRP")]
    public decimal CfdValorPrp { get; set; }

    [Column("CFD_VALOR_CDT")]
    public decimal CfdValorCdt { get; set; }

    [Column("CFD_VALOR_ISC")]
    public decimal CfdValorIsc { get; set; }

    [Column("CFD_FACTURA")]
    public int CfdFactura { get; set; }

    [Column("CFD_FORMA_PAGO")]
    public int? CfdFormaPago { get; set; }
}
