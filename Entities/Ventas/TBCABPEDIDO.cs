using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBCABPEDIDO")]
public class TBCABPEDIDO
{
    [Column("CPE_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CpeInternoNo { get; set; }

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

    [Column("CPE_NUMERO")]
    public int CpeNumero { get; set; }

    [Column("VEN_CODIGO")]
    public int VenCodigo { get; set; }

    [Column("CPG_CODIGO")]
    public int CpgCodigo { get; set; }

    [Column("LEC_CODIGO")]
    public int? LecCodigo { get; set; }

    [Column("CPE_COMPANIA")]
    public int CpeCompania { get; set; }

    [Column("CPE_CTE_CODIGO")]
    public required string CpeCteCodigo { get; set; }

    [Column("CPE_CTE_NOMBRE")]
    public string? CpeCteNombre { get; set; }

    [Column("CPE_CTE_DIRECCION")]
    public string? CpeCteDireccion { get; set; }

    [Column("CPE_CTE_TELEFONO")]
    public string? CpeCteTelefono { get; set; }

    [Column("CPE_CTE_CEDULA_RNC")]
    public string? CpeCteCedulaRnc { get; set; }

    [Column("CPE_FECHA")]
    public DateTime CpeFecha { get; set; }

    [Column("CPE_FECHA_ENTREGA")]
    public DateTime? CpeFechaEntrega { get; set; }

    [Column("CPE_PROCESO")]
    public DateTime CpeProceso { get; set; }

    [Column("CPE_ORDEN_CTE")]
    public string? CpeOrdenCte { get; set; }

    [Column("CPE_DESC_PORC")]
    public decimal CpeDescPorc { get; set; }

    [Column("CPE_IMP_USA")]
    public bool CpeImpUsa { get; set; }

    [Column("CPE_IMP_PORC")]
    public decimal? CpeImpPorc { get; set; }

    [Column("CPE_VALOR_BRUTO")]
    public decimal CpeValorBruto { get; set; }

    [Column("CPE_VALOR_DESCUENTO")]
    public decimal CpeValorDescuento { get; set; }

    [Column("CPE_VALOR_IMPUESTO")]
    public decimal CpeValorImpuesto { get; set; }

    [Column("CPE_VALOR_FLETE")]
    public decimal CpeValorFlete { get; set; }

    [Column("CPE_VALOR_SEGURO")]
    public decimal CpeValorSeguro { get; set; }

    [Column("CPE_VALOR_OTRO")]
    public decimal CpeValorOtro { get; set; }

    [Column("CPE_TASA")]
    public decimal? CpeTasa { get; set; }

    [Column("CPE_NOTA_PIE")]
    public string? CpeNotaPie { get; set; }

    [Column("CPE_NOTA_2")]
    public string? CpeNota2 { get; set; }

    [Column("CPE_ESTADO_PEDIDO")]
    public required string CpeEstadoPedido { get; set; }

    [Column("CPE_ELABORADO_POR")]
    public required string CpeElaboradoPor { get; set; }

    [Column("CPE_GENERADO")]
    public required string CpeGenerado { get; set; }

    [Column("CPE_IMPRESO")]
    public bool CpeImpreso { get; set; }

    [Column("CPE_EXPORTADO")]
    public bool CpeExportado { get; set; }

    [Column("CPE_CORREO")]
    public bool CpeCorreo { get; set; }

    [Column("CPE_POSTEADO")]
    public bool CpePosteado { get; set; }

    [Column("CPE_NULO")]
    public bool CpeNulo { get; set; }

    [Column("CPE_ESTADO")]
    public bool CpeEstado { get; set; }

    [Column("CPE_APROBADO")]
    public bool CpeAprobado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }

    [Column("CPE_VALOR_PRP")]
    public decimal CpeValorPrp { get; set; }

    [Column("CPE_VALOR_CDT")]
    public decimal CpeValorCdt { get; set; }

    [Column("CPE_VALOR_ISC")]
    public decimal CpeValorIsc { get; set; }

    [Column("CPE_VALOR_ESP")]
    public decimal CpeValorEsp { get; set; }

    [Column("CPE_VALOR_ADV")]
    public decimal CpeValorAdv { get; set; }

    [Column("TRP_CODIGO")]
    public int? TrpCodigo { get; set; }

    [Column("REP_CODIGO")]
    public int? RepCodigo { get; set; }

    [Column("CPE_ENTRG_NOMBRE")]
    public string? CpeEntrgNombre { get; set; }

    [Column("CPE_ENTRG_FECHA")]
    public DateTime? CpeEntrgFecha { get; set; }
}
