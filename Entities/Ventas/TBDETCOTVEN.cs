using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBDETCOTVEN")]
public class TBDETCOTVEN
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

    [Column("CCV_NUMERO")]
    public int CcvNumero { get; set; }

    [Column("DCV_SECUENCIA")]
    public int DcvSecuencia { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("ALM_CODIGO")]
    public int AlmCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DCV_COMPANIA")]
    public int DcvCompania { get; set; }

    [Column("DCV_PRD_NOMBRE")]
    public string? DcvPrdNombre { get; set; }

    [Column("DCV_CANTIDAD")]
    public decimal DcvCantidad { get; set; }

    [Column("DCV_BONIFICADO")]
    public decimal DcvBonificado { get; set; }

    [Column("DCV_FACTOR")]
    public decimal DcvFactor { get; set; }

    [Column("DCV_PRECIO")]
    public decimal DcvPrecio { get; set; }

    [Column("DCV_DESC_PORC")]
    public decimal DcvDescPorc { get; set; }

    [Column("DCV_IMP_USA")]
    public bool DcvImpUsa { get; set; }

    [Column("DCV_IMP_PORC")]
    public decimal? DcvImpPorc { get; set; }

    [Column("DCV_NOTA")]
    public string? DcvNota { get; set; }

    [Column("DCV_IMPRESO")]
    public bool DcvImpreso { get; set; }

    [Column("DCV_POSTEADO")]
    public bool DcvPosteado { get; set; }

    [Column("DCV_ESTADO")]
    public bool DcvEstado { get; set; }

    [Column("DCV_GENCNT")]
    public decimal DcvGencnt { get; set; }

    [Column("DCV_GENBNF")]
    public decimal DcvGenbnf { get; set; }

    [Column("DCV_TASA_PRP")]
    public decimal DcvTasaPrp { get; set; }

    [Column("DCV_TASA_CDT")]
    public decimal DcvTasaCdt { get; set; }

    [Column("DCV_TASA_ISC")]
    public decimal DcvTasaIsc { get; set; }

    [Column("DCV_TASA_ESP")]
    public decimal DcvTasaEsp { get; set; }

    [Column("DCV_TASA_ADV")]
    public decimal DcvTasaAdv { get; set; }
}
