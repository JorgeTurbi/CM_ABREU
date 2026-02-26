namespace ApiCm.DTOs.Ventas;

public sealed class TBDETFACDEVDTO
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdvTipo { get; set; }
    public int TdvCodigo { get; set; }
    public required string DnvAno { get; set; }
    public int CfdNumero { get; set; }
    public int DfdSecuencia { get; set; }
    public int AlmCodigo { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public int DfdCompania { get; set; }
    public string? DfdPrdNombre { get; set; }
    public required string DfdItemTpo { get; set; }
    public int? DfdItemSeq { get; set; }
    public DateTime DfdFecha { get; set; }
    public decimal DfdCantidad { get; set; }
    public decimal DfdBonificado { get; set; }
    public decimal DfdFactor { get; set; }
    public decimal DfdPrecio { get; set; }
    public decimal DfdDescPorc { get; set; }
    public bool DfdImpUsa { get; set; }
    public decimal? DfdImpPorc { get; set; }
    public decimal DfdTasaAdv { get; set; }
    public decimal DfdTasaEsp { get; set; }
    public decimal DfdCostoUnd { get; set; }
    public string? DfdNota { get; set; }
    public bool DfdImpreso { get; set; }
    public bool DfdPosteado { get; set; }
    public bool DfdEstado { get; set; }
    public decimal DfdGencnt { get; set; }
    public decimal DfdGenbnf { get; set; }
    public string? DfdSerie { get; set; }
    public decimal DfdTasaPrp { get; set; }
    public decimal DfdTasaCdt { get; set; }
    public decimal DfdTasaIsc { get; set; }
}
