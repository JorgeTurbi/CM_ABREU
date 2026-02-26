using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBCABCONDUCE")]
public class TBCABCONDUCE
{
    [Column("CCN_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CcnInternoNo { get; set; }

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

    [Column("CCN_NUMERO")]
    public int CcnNumero { get; set; }

    [Column("CPG_CODIGO")]
    public int CpgCodigo { get; set; }

    [Column("TRP_CODIGO")]
    public int? TrpCodigo { get; set; }

    [Column("VEN_CODIGO")]
    public int VenCodigo { get; set; }

    [Column("LEC_CODIGO")]
    public int? LecCodigo { get; set; }

    [Column("REP_CODIGO")]
    public int? RepCodigo { get; set; }

    [Column("CCN_COMPANIA")]
    public int CcnCompania { get; set; }

    [Column("CCN_CTE_CODIGO")]
    public required string CcnCteCodigo { get; set; }

    [Column("CCN_CTE_NOMBRE")]
    public string? CcnCteNombre { get; set; }

    [Column("CCN_CTE_DIRECCION")]
    public string? CcnCteDireccion { get; set; }

    [Column("CCN_CTE_TELEFONO")]
    public string? CcnCteTelefono { get; set; }

    [Column("CCN_CTE_CEDULA_RNC")]
    public string? CcnCteCedulaRnc { get; set; }

    [Column("CCN_FECHA")]
    public DateTime CcnFecha { get; set; }

    [Column("CCN_PROCESO")]
    public DateTime CcnProceso { get; set; }

    [Column("CCN_DIAS")]
    public int? CcnDias { get; set; }

    [Column("CCN_ORDEN_CTE")]
    public string? CcnOrdenCte { get; set; }

    [Column("CCN_DESC_PORC")]
    public decimal CcnDescPorc { get; set; }

    [Column("CCN_IMP_USA")]
    public bool CcnImpUsa { get; set; }

    [Column("CCN_IMP_PORC")]
    public decimal? CcnImpPorc { get; set; }

    [Column("CCN_VALOR_BRUTO")]
    public decimal CcnValorBruto { get; set; }

    [Column("CCN_VALOR_DESCUENTO")]
    public decimal CcnValorDescuento { get; set; }

    [Column("CCN_VALOR_IMPUESTO")]
    public decimal CcnValorImpuesto { get; set; }

    [Column("CCN_VALOR_FLETE")]
    public decimal CcnValorFlete { get; set; }

    [Column("CCN_VALOR_SEGURO")]
    public decimal CcnValorSeguro { get; set; }

    [Column("CCN_VALOR_OTRO")]
    public decimal CcnValorOtro { get; set; }

    [Column("CCN_TASA")]
    public decimal? CcnTasa { get; set; }

    [Column("CCN_NOTA_PIE")]
    public string? CcnNotaPie { get; set; }

    [Column("CCN_NOTA_2")]
    public string? CcnNota2 { get; set; }

    [Column("CCN_ENTRG_NOMBRE")]
    public string? CcnEntrgNombre { get; set; }

    [Column("CCN_ENTRG_FECHA")]
    public DateTime? CcnEntrgFecha { get; set; }

    [Column("CCN_ELABORADO_POR")]
    public required string CcnElaboradoPor { get; set; }

    [Column("CCN_GENERADO")]
    public required string CcnGenerado { get; set; }

    [Column("CCN_IMPRESO")]
    public bool CcnImpreso { get; set; }

    [Column("CCN_EXPORTADO")]
    public bool CcnExportado { get; set; }

    [Column("CCN_CORREO")]
    public bool CcnCorreo { get; set; }

    [Column("CCN_POSTEADO")]
    public bool CcnPosteado { get; set; }

    [Column("CCN_NULO")]
    public bool CcnNulo { get; set; }

    [Column("CCN_ESTADO")]
    public bool CcnEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }

    [Column("CCN_VALOR_PRP")]
    public decimal CcnValorPrp { get; set; }

    [Column("CCN_VALOR_CDT")]
    public decimal CcnValorCdt { get; set; }

    [Column("CCN_VALOR_ISC")]
    public decimal CcnValorIsc { get; set; }

    [Column("CCN_VALOR_ESP")]
    public decimal CcnValorEsp { get; set; }

    [Column("CCN_VALOR_ADV")]
    public decimal CcnValorAdv { get; set; }
}
