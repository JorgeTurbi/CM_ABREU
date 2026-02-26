using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBDETPEDIDO")]
public class TBDETPEDIDO
{
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

    [Column("DPE_SECUENCIA")]
    public int DpeSecuencia { get; set; }

    [Column("ALM_CODIGO")]
    public int AlmCodigo { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DPE_COMPANIA")]
    public int DpeCompania { get; set; }

    [Column("DPE_PRD_NOMBRE")]
    public string? DpePrdNombre { get; set; }

    [Column("DPE_CANTIDAD")]
    public decimal DpeCantidad { get; set; }

    [Column("DPE_BONIFICADO")]
    public decimal DpeBonificado { get; set; }

    [Column("DPE_FACTOR")]
    public decimal DpeFactor { get; set; }

    [Column("DPE_PRECIO")]
    public decimal DpePrecio { get; set; }

    [Column("DPE_DESC_PORC")]
    public decimal DpeDescPorc { get; set; }

    [Column("DPE_IMP_USA")]
    public bool DpeImpUsa { get; set; }

    [Column("DPE_IMP_PORC")]
    public decimal? DpeImpPorc { get; set; }

    [Column("DPE_NOTA")]
    public string? DpeNota { get; set; }

    [Column("DPE_IMPRESO")]
    public bool DpeImpreso { get; set; }

    [Column("DPE_POSTEADO")]
    public bool DpePosteado { get; set; }

    [Column("DPE_ESTADO")]
    public bool DpeEstado { get; set; }

    [Column("DPE_GENCNT")]
    public decimal DpeGencnt { get; set; }

    [Column("DPE_GENBNF")]
    public decimal DpeGenbnf { get; set; }

    [Column("DPE_TASA_PRP")]
    public decimal DpeTasaPrp { get; set; }

    [Column("DPE_TASA_CDT")]
    public decimal DpeTasaCdt { get; set; }

    [Column("DPE_TASA_ISC")]
    public decimal DpeTasaIsc { get; set; }

    [Column("DPE_TASA_ESP")]
    public decimal DpeTasaEsp { get; set; }

    [Column("DPE_TASA_ADV")]
    public decimal DpeTasaAdv { get; set; }
}
