namespace ApiCm.DTOs.Ventas;

public sealed class TBDETCOTVENDTO
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdvTipo { get; set; }
    public int TdvCodigo { get; set; }
    public required string DnvAno { get; set; }
    public int CcvNumero { get; set; }
    public int DcvSecuencia { get; set; }
    public required string PrdCodigo { get; set; }
    public int AlmCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public int DcvCompania { get; set; }
    public string? DcvPrdNombre { get; set; }
    public decimal DcvCantidad { get; set; }
    public decimal DcvBonificado { get; set; }
    public decimal DcvFactor { get; set; }
    public decimal DcvPrecio { get; set; }
    public decimal DcvDescPorc { get; set; }
    public bool DcvImpUsa { get; set; }
    public decimal? DcvImpPorc { get; set; }
    public string? DcvNota { get; set; }
    public bool DcvImpreso { get; set; }
    public bool DcvPosteado { get; set; }
    public bool DcvEstado { get; set; }
    public decimal DcvGencnt { get; set; }
    public decimal DcvGenbnf { get; set; }
    public decimal DcvTasaPrp { get; set; }
    public decimal DcvTasaCdt { get; set; }
    public decimal DcvTasaIsc { get; set; }
    public decimal DcvTasaEsp { get; set; }
    public decimal DcvTasaAdv { get; set; }
}
