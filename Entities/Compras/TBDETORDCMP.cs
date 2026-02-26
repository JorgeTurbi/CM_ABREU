using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBDETORDCMP")]
public class TBDETORDCMP
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

    [Column("COC_NUMERO")]
    public int CocNumero { get; set; }

    [Column("DOC_SECUENCIA")]
    public int DocSecuencia { get; set; }

    [Column("DOC_COMPANIA")]
    public int DocCompania { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DOC_PRD_NOMBRE")]
    public string? DocPrdNombre { get; set; }

    [Column("DOC_FECHA")]
    public DateTime DocFecha { get; set; }

    [Column("DOC_CANTIDAD")]
    public decimal DocCantidad { get; set; }

    [Column("DOC_FACTOR")]
    public decimal DocFactor { get; set; }

    [Column("DOC_COSTO_UND")]
    public decimal DocCostoUnd { get; set; }

    [Column("DOC_IMP_USA")]
    public bool DocImpUsa { get; set; }

    [Column("DOC_IMP_PORC")]
    public decimal? DocImpPorc { get; set; }

    [Column("DOC_DESC_PORC")]
    public decimal DocDescPorc { get; set; }

    [Column("DOC_NOTA")]
    public string? DocNota { get; set; }

    [Column("DOC_IMPRESO")]
    public bool DocImpreso { get; set; }

    [Column("DOC_POSTEADO")]
    public bool DocPosteado { get; set; }

    [Column("DOC_ESTADO")]
    public bool DocEstado { get; set; }

    [Column("DOC_GENCNT")]
    public decimal DocGencnt { get; set; }

    [Column("DOC_BONIFICADO")]
    public decimal DocBonificado { get; set; }

    [Column("DOC_GENBNF")]
    public decimal DocGenbnf { get; set; }
}
