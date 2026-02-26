using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBDETLIQMER")]
public class TBDETLIQMER
{
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

    [Column("DLQ_SECUENCIA")]
    public int DlqSecuencia { get; set; }

    [Column("DLQ_COMPANIA")]
    public int DlqCompania { get; set; }

    [Column("ALM_CODIGO")]
    public int AlmCodigo { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DLQ_PRD_NOMBRE")]
    public string? DlqPrdNombre { get; set; }

    [Column("DLQ_FECHA")]
    public DateTime DlqFecha { get; set; }

    [Column("DLQ_CANTIDAD")]
    public decimal DlqCantidad { get; set; }

    [Column("DLQ_FACTOR")]
    public decimal DlqFactor { get; set; }

    [Column("DLQ_PESO")]
    public decimal DlqPeso { get; set; }

    [Column("DLQ_COSTO_UND")]
    public decimal DlqCostoUnd { get; set; }

    [Column("DLQ_IMP_ADUANA")]
    public decimal DlqImpAduana { get; set; }

    [Column("DLQ_NOTA")]
    public string? DlqNota { get; set; }

    [Column("DLQ_IMPRESO")]
    public bool DlqImpreso { get; set; }

    [Column("DLQ_POSTEADO")]
    public bool DlqPosteado { get; set; }

    [Column("DLQ_ESTADO")]
    public bool DlqEstado { get; set; }

    [Column("DLQ_SERIE")]
    public string? DlqSerie { get; set; }
}
