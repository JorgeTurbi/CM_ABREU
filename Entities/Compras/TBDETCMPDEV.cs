using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBDETCMPDEV")]
public class TBDETCMPDEV
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

    [Column("CCD_NUMERO")]
    public int CcdNumero { get; set; }

    [Column("DCD_SECUENCIA")]
    public int DcdSecuencia { get; set; }

    [Column("DCD_COMPANIA")]
    public int DcdCompania { get; set; }

    [Column("ALM_CODIGO")]
    public int AlmCodigo { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DCD_PRD_NOMBRE")]
    public string? DcdPrdNombre { get; set; }

    [Column("DCD_FECHA")]
    public DateTime DcdFecha { get; set; }

    [Column("DCD_CANTIDAD")]
    public decimal DcdCantidad { get; set; }

    [Column("DCD_FACTOR")]
    public decimal DcdFactor { get; set; }

    [Column("DCD_COSTO_UND")]
    public decimal DcdCostoUnd { get; set; }

    [Column("DCD_IMP_USA")]
    public bool DcdImpUsa { get; set; }

    [Column("DCD_IMP_PORC")]
    public decimal? DcdImpPorc { get; set; }

    [Column("DCD_DESC_PORC")]
    public decimal DcdDescPorc { get; set; }

    [Column("DCD_NOTA")]
    public string? DcdNota { get; set; }

    [Column("DCD_IMPRESO")]
    public bool DcdImpreso { get; set; }

    [Column("DCD_POSTEADO")]
    public bool DcdPosteado { get; set; }

    [Column("DCD_ESTADO")]
    public bool DcdEstado { get; set; }

    [Column("DCD_GENCNT")]
    public decimal DcdGencnt { get; set; }

    [Column("DCD_BONIFICADO")]
    public decimal DcdBonificado { get; set; }

    [Column("DCD_GENBNF")]
    public decimal DcdGenbnf { get; set; }

    [Column("DCD_SERIE")]
    public string? DcdSerie { get; set; }
}
