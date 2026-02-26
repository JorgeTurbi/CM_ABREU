using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBCABORDCMP")]
public class TBCABORDCMP
{
    [Column("COC_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CocInternoNo { get; set; }

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

    [Column("COC_NUMERO")]
    public int CocNumero { get; set; }

    [Column("COC_COMPANIA")]
    public int CocCompania { get; set; }

    [Column("CPG_CODIGO")]
    public int CpgCodigo { get; set; }

    [Column("LEP_CODIGO")]
    public int? LepCodigo { get; set; }

    [Column("ENV_CODIGO")]
    public int? EnvCodigo { get; set; }

    [Column("CTE_CODIGO")]
    public string? CteCodigo { get; set; }

    [Column("COC_FECHA")]
    public DateTime CocFecha { get; set; }

    [Column("COC_FECHA_EMBARQUE")]
    public DateTime? CocFechaEmbarque { get; set; }

    [Column("COC_FECHA_ENTREGA")]
    public DateTime? CocFechaEntrega { get; set; }

    [Column("COC_PROCESO")]
    public DateTime CocProceso { get; set; }

    [Column("COC_PRV_CODIGO")]
    public string? CocPrvCodigo { get; set; }

    [Column("COC_PRV_NOMBRE")]
    public string? CocPrvNombre { get; set; }

    [Column("COC_PRV_REFERENCIA")]
    public string? CocPrvReferencia { get; set; }

    [Column("COC_CTE_ORDEN")]
    public string? CocCteOrden { get; set; }

    [Column("COC_DESC_PORC")]
    public decimal CocDescPorc { get; set; }

    [Column("COC_IMP_USA")]
    public bool CocImpUsa { get; set; }

    [Column("COC_IMP_PORC")]
    public decimal? CocImpPorc { get; set; }

    [Column("COC_VALOR_BRUTO")]
    public decimal CocValorBruto { get; set; }

    [Column("COC_VALOR_DESCUENTO")]
    public decimal CocValorDescuento { get; set; }

    [Column("COC_VALOR_IMPUESTO")]
    public decimal CocValorImpuesto { get; set; }

    [Column("COC_VALOR_FLETE")]
    public decimal CocValorFlete { get; set; }

    [Column("COC_VALOR_SEGURO")]
    public decimal CocValorSeguro { get; set; }

    [Column("COC_VALOR_OTRO")]
    public decimal CocValorOtro { get; set; }

    [Column("COC_TASA")]
    public decimal? CocTasa { get; set; }

    [Column("COC_NOTA_PIE")]
    public string? CocNotaPie { get; set; }

    [Column("COC_ELABORADO_POR")]
    public required string CocElaboradoPor { get; set; }

    [Column("COC_GENERADO")]
    public required string CocGenerado { get; set; }

    [Column("COC_IMPRESO")]
    public bool CocImpreso { get; set; }

    [Column("COC_EXPORTADO")]
    public bool CocExportado { get; set; }

    [Column("COC_CORREO")]
    public bool CocCorreo { get; set; }

    [Column("COC_POSTEADO")]
    public bool CocPosteado { get; set; }

    [Column("COC_NULO")]
    public bool CocNulo { get; set; }

    [Column("COC_ESTADO")]
    public bool CocEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }
}
