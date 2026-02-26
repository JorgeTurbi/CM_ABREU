using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBCABCOTVEN")]
public class TBCABCOTVEN
{
    [Column("CCV_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CcvInternoNo { get; set; }

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

    [Column("CCV_NUMERO")]
    public int CcvNumero { get; set; }

    [Column("TEN_CODIGO")]
    public int? TenCodigo { get; set; }

    [Column("VEN_CODIGO")]
    public int VenCodigo { get; set; }

    [Column("CPG_CODIGO")]
    public int CpgCodigo { get; set; }

    [Column("CCV_COMPANIA")]
    public int CcvCompania { get; set; }

    [Column("CCV_FECHA")]
    public DateTime CcvFecha { get; set; }

    [Column("CCV_PROCESO")]
    public DateTime CcvProceso { get; set; }

    [Column("CCV_CTE_CODIGO")]
    public required string CcvCteCodigo { get; set; }

    [Column("CCV_CTE_NOMBRE")]
    public string? CcvCteNombre { get; set; }

    [Column("CCV_CTE_DIRECCION")]
    public string? CcvCteDireccion { get; set; }

    [Column("CCV_CTE_TELEFONO")]
    public string? CcvCteTelefono { get; set; }

    [Column("CCV_CTE_CEDULA_RNC")]
    public string? CcvCteCedulaRnc { get; set; }

    [Column("CCV_ORDEN_CTE")]
    public string? CcvOrdenCte { get; set; }

    [Column("CCV_DESC_PORC")]
    public decimal CcvDescPorc { get; set; }

    [Column("CCV_IMP_USA")]
    public bool CcvImpUsa { get; set; }

    [Column("CCV_IMP_PORC")]
    public decimal? CcvImpPorc { get; set; }

    [Column("CCV_VALOR_BRUTO")]
    public decimal CcvValorBruto { get; set; }

    [Column("CCV_VALOR_DESCUENTO")]
    public decimal CcvValorDescuento { get; set; }

    [Column("CCV_VALOR_IMPUESTO")]
    public decimal CcvValorImpuesto { get; set; }

    [Column("CCV_VALOR_FLETE")]
    public decimal CcvValorFlete { get; set; }

    [Column("CCV_VALOR_SEGURO")]
    public decimal CcvValorSeguro { get; set; }

    [Column("CCV_VALOR_OTRO")]
    public decimal CcvValorOtro { get; set; }

    [Column("CCV_TASA")]
    public decimal? CcvTasa { get; set; }

    [Column("CCV_NOTA_PIE")]
    public string? CcvNotaPie { get; set; }

    [Column("CCV_NOTA_2")]
    public string? CcvNota2 { get; set; }

    [Column("CCV_ELABORADO_POR")]
    public required string CcvElaboradoPor { get; set; }

    [Column("CCV_GENERADO")]
    public required string CcvGenerado { get; set; }

    [Column("CCV_IMPRESO")]
    public bool CcvImpreso { get; set; }

    [Column("CCV_EXPORTADO")]
    public bool CcvExportado { get; set; }

    [Column("CCV_CORREO")]
    public bool CcvCorreo { get; set; }

    [Column("CCV_POSTEADO")]
    public bool CcvPosteado { get; set; }

    [Column("CCV_NULO")]
    public bool CcvNulo { get; set; }

    [Column("CCV_ESTADO")]
    public bool CcvEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }

    [Column("CCV_VALOR_PRP")]
    public decimal CcvValorPrp { get; set; }

    [Column("CCV_VALOR_CDT")]
    public decimal CcvValorCdt { get; set; }

    [Column("CCV_VALOR_ISC")]
    public decimal CcvValorIsc { get; set; }

    [Column("CCV_VALOR_ESP")]
    public decimal CcvValorEsp { get; set; }

    [Column("CCV_VALOR_ADV")]
    public decimal CcvValorAdv { get; set; }
}
