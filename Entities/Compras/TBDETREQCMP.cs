using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBDETREQCMP")]
public class TBDETREQCMP
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

    [Column("CRP_NUMERO")]
    public int CrpNumero { get; set; }

    [Column("DRP_SECUENCIA")]
    public int DrpSecuencia { get; set; }

    [Column("DRP_COMPANIA")]
    public int DrpCompania { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DRP_PRD_NOMBRE")]
    public string? DrpPrdNombre { get; set; }

    [Column("DRP_CANTIDAD")]
    public decimal DrpCantidad { get; set; }

    [Column("DRP_FACTOR")]
    public decimal DrpFactor { get; set; }

    [Column("DRP_NOTA")]
    public string? DrpNota { get; set; }

    [Column("DRP_IMPRESO")]
    public bool DrpImpreso { get; set; }

    [Column("DRP_POSTEADO")]
    public bool DrpPosteado { get; set; }

    [Column("DRP_ESTADO")]
    public bool DrpEstado { get; set; }

    [Column("DRP_GENCNT")]
    public decimal DrpGencnt { get; set; }

    [Column("DRP_BONIFICADO")]
    public decimal DrpBonificado { get; set; }

    [Column("DRP_GENBNF")]
    public decimal DrpGenbnf { get; set; }
}
