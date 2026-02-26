namespace ApiCm.DTOs.Ventas;

public sealed class TBDETCONDUCEDTO
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdvTipo { get; set; }
    public int TdvCodigo { get; set; }
    public required string DnvAno { get; set; }
    public int CcnNumero { get; set; }
    public int DcnSecuencia { get; set; }
    public int AlmCodigo { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public int DcnCompania { get; set; }
    public string? DcnPrdNombre { get; set; }
    public decimal DcnCantidad { get; set; }
    public decimal DcnBonificado { get; set; }
    public decimal DcnFactor { get; set; }
    public decimal DcnPrecio { get; set; }
    public decimal DcnDescPorc { get; set; }
    public bool DcnImpUsa { get; set; }
    public decimal? DcnImpPorc { get; set; }
    public string? DcnNota { get; set; }
    public bool DcnImpreso { get; set; }
    public bool DcnPosteado { get; set; }
    public bool DcnEstado { get; set; }
    public decimal DcnGencnt { get; set; }
    public decimal DcnGenbnf { get; set; }
    public string? DcnSerie { get; set; }
    public decimal DcnTasaPrp { get; set; }
    public decimal DcnTasaCdt { get; set; }
    public decimal DcnTasaIsc { get; set; }
    public decimal DcnTasaEsp { get; set; }
    public decimal DcnTasaAdv { get; set; }
}
