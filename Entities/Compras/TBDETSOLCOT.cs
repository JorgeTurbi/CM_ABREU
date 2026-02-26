using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBDETSOLCOT")]
public class TBDETSOLCOT
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

    [Column("CST_NUMERO")]
    public int CstNumero { get; set; }

    [Column("DST_SECUENCIA")]
    public int DstSecuencia { get; set; }

    [Column("DST_COMPANIA")]
    public int DstCompania { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DST_PRD_NOMBRE")]
    public string? DstPrdNombre { get; set; }

    [Column("DST_CANTIDAD")]
    public decimal DstCantidad { get; set; }

    [Column("DST_FACTOR")]
    public decimal DstFactor { get; set; }

    [Column("DST_NOTA")]
    public string? DstNota { get; set; }

    [Column("DST_IMPRESO")]
    public bool DstImpreso { get; set; }

    [Column("DST_POSTEADO")]
    public bool DstPosteado { get; set; }

    [Column("DST_ESTADO")]
    public bool DstEstado { get; set; }

    [Column("DST_GENCNT")]
    public decimal DstGencnt { get; set; }

    [Column("DST_BONIFICADO")]
    public decimal DstBonificado { get; set; }

    [Column("DST_GENBNF")]
    public decimal DstGenbnf { get; set; }
}
