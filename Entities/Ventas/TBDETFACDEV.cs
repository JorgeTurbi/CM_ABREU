using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBDETFACDEV")]
public class TBDETFACDEV
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

    [Column("CFD_NUMERO")]
    public int CfdNumero { get; set; }

    [Column("DFD_SECUENCIA")]
    public int DfdSecuencia { get; set; }

    [Column("ALM_CODIGO")]
    public int AlmCodigo { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DFD_COMPANIA")]
    public int DfdCompania { get; set; }

    [Column("DFD_PRD_NOMBRE")]
    public string? DfdPrdNombre { get; set; }

    [Column("DFD_ITEM_TPO")]
    public required string DfdItemTpo { get; set; }

    [Column("DFD_ITEM_SEQ")]
    public int? DfdItemSeq { get; set; }

    [Column("DFD_FECHA")]
    public DateTime DfdFecha { get; set; }

    [Column("DFD_CANTIDAD")]
    public decimal DfdCantidad { get; set; }

    [Column("DFD_BONIFICADO")]
    public decimal DfdBonificado { get; set; }

    [Column("DFD_FACTOR")]
    public decimal DfdFactor { get; set; }

    [Column("DFD_PRECIO")]
    public decimal DfdPrecio { get; set; }

    [Column("DFD_DESC_PORC")]
    public decimal DfdDescPorc { get; set; }

    [Column("DFD_IMP_USA")]
    public bool DfdImpUsa { get; set; }

    [Column("DFD_IMP_PORC")]
    public decimal? DfdImpPorc { get; set; }

    [Column("DFD_TASA_ADV")]
    public decimal DfdTasaAdv { get; set; }

    [Column("DFD_TASA_ESP")]
    public decimal DfdTasaEsp { get; set; }

    [Column("DFD_COSTO_UND")]
    public decimal DfdCostoUnd { get; set; }

    [Column("DFD_NOTA")]
    public string? DfdNota { get; set; }

    [Column("DFD_IMPRESO")]
    public bool DfdImpreso { get; set; }

    [Column("DFD_POSTEADO")]
    public bool DfdPosteado { get; set; }

    [Column("DFD_ESTADO")]
    public bool DfdEstado { get; set; }

    [Column("DFD_GENCNT")]
    public decimal DfdGencnt { get; set; }

    [Column("DFD_GENBNF")]
    public decimal DfdGenbnf { get; set; }

    [Column("DFD_SERIE")]
    public string? DfdSerie { get; set; }

    [Column("DFD_TASA_PRP")]
    public decimal DfdTasaPrp { get; set; }

    [Column("DFD_TASA_CDT")]
    public decimal DfdTasaCdt { get; set; }

    [Column("DFD_TASA_ISC")]
    public decimal DfdTasaIsc { get; set; }
}
