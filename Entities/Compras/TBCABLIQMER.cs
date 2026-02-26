using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBCABLIQMER")]
public class TBCABLIQMER
{
    [Column("CLQ_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long ClqInternoNo { get; set; }

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

    [Column("CLQ_NUMERO")]
    public int ClqNumero { get; set; }

    [Column("CLQ_COMPANIA")]
    public int ClqCompania { get; set; }

    [Column("CPG_CODIGO")]
    public int CpgCodigo { get; set; }

    [Column("PRV_CODIGO")]
    public required string PrvCodigo { get; set; }

    [Column("CCT_CODIGO")]
    public int? CctCodigo { get; set; }

    [Column("CLQ_FECHA")]
    public DateTime ClqFecha { get; set; }

    [Column("CLQ_FECHA_FACTURA")]
    public DateTime? ClqFechaFactura { get; set; }

    [Column("CLQ_FECHA_RECIBIDA")]
    public DateTime? ClqFechaRecibida { get; set; }

    [Column("CLQ_PROCESO")]
    public DateTime ClqProceso { get; set; }

    [Column("CLQ_ORDEN")]
    public int? ClqOrden { get; set; }

    [Column("CLQ_FACTURA")]
    public required string ClqFactura { get; set; }

    [Column("CLQ_IMPORTACION")]
    public string? ClqImportacion { get; set; }

    [Column("CLQ_TOTAL_LIQ")]
    public decimal ClqTotalLiq { get; set; }

    [Column("CLQ_NOTA_PIE")]
    public string? ClqNotaPie { get; set; }

    [Column("CLQ_ELABORADO_POR")]
    public required string ClqElaboradoPor { get; set; }

    [Column("CLQ_GENERADO")]
    public bool ClqGenerado { get; set; }

    [Column("CLQ_IMPRESO")]
    public bool ClqImpreso { get; set; }

    [Column("CLQ_EXPORTADO")]
    public bool ClqExportado { get; set; }

    [Column("CLQ_CORREO")]
    public bool ClqCorreo { get; set; }

    [Column("CLQ_POSTEADO")]
    public bool ClqPosteado { get; set; }

    [Column("CLQ_NULO")]
    public bool ClqNulo { get; set; }

    [Column("CLQ_ESTADO")]
    public bool ClqEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }

    [Column("CLQ_MARGEN")]
    public decimal? ClqMargen { get; set; }

    [Column("CLQ_TASA_POSTEO")]
    public decimal? ClqTasaPosteo { get; set; }

    [Column("CLQ_EMBARQUE")]
    public string? ClqEmbarque { get; set; }

    [Column("CLQ_EXPLIQ_MON")]
    public int? ClqExpliqMon { get; set; }

    [Column("CLQ_EXPLIQ_NUM")]
    public int? ClqExpliqNum { get; set; }
}
