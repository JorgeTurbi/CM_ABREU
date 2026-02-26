using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBDETCONDUCE")]
public class TBDETCONDUCE
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

    [Column("CCN_NUMERO")]
    public int CcnNumero { get; set; }

    [Column("DCN_SECUENCIA")]
    public int DcnSecuencia { get; set; }

    [Column("ALM_CODIGO")]
    public int AlmCodigo { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DCN_COMPANIA")]
    public int DcnCompania { get; set; }

    [Column("DCN_PRD_NOMBRE")]
    public string? DcnPrdNombre { get; set; }

    [Column("DCN_CANTIDAD")]
    public decimal DcnCantidad { get; set; }

    [Column("DCN_BONIFICADO")]
    public decimal DcnBonificado { get; set; }

    [Column("DCN_FACTOR")]
    public decimal DcnFactor { get; set; }

    [Column("DCN_PRECIO")]
    public decimal DcnPrecio { get; set; }

    [Column("DCN_DESC_PORC")]
    public decimal DcnDescPorc { get; set; }

    [Column("DCN_IMP_USA")]
    public bool DcnImpUsa { get; set; }

    [Column("DCN_IMP_PORC")]
    public decimal? DcnImpPorc { get; set; }

    [Column("DCN_NOTA")]
    public string? DcnNota { get; set; }

    [Column("DCN_IMPRESO")]
    public bool DcnImpreso { get; set; }

    [Column("DCN_POSTEADO")]
    public bool DcnPosteado { get; set; }

    [Column("DCN_ESTADO")]
    public bool DcnEstado { get; set; }

    [Column("DCN_GENCNT")]
    public decimal DcnGencnt { get; set; }

    [Column("DCN_GENBNF")]
    public decimal DcnGenbnf { get; set; }

    [Column("DCN_SERIE")]
    public string? DcnSerie { get; set; }

    [Column("DCN_TASA_PRP")]
    public decimal DcnTasaPrp { get; set; }

    [Column("DCN_TASA_CDT")]
    public decimal DcnTasaCdt { get; set; }

    [Column("DCN_TASA_ISC")]
    public decimal DcnTasaIsc { get; set; }

    [Column("DCN_TASA_ESP")]
    public decimal DcnTasaEsp { get; set; }

    [Column("DCN_TASA_ADV")]
    public decimal DcnTasaAdv { get; set; }
}
