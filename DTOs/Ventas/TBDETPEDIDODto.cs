namespace ApiCm.DTOs.Ventas;

public sealed class TBDETPEDIDODTO
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdvTipo { get; set; }
    public int TdvCodigo { get; set; }
    public required string DnvAno { get; set; }
    public int CpeNumero { get; set; }
    public int DpeSecuencia { get; set; }
    public int AlmCodigo { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public int DpeCompania { get; set; }
    public string? DpePrdNombre { get; set; }
    public decimal DpeCantidad { get; set; }
    public decimal DpeBonificado { get; set; }
    public decimal DpeFactor { get; set; }
    public decimal DpePrecio { get; set; }
    public decimal DpeDescPorc { get; set; }
    public bool DpeImpUsa { get; set; }
    public decimal? DpeImpPorc { get; set; }
    public string? DpeNota { get; set; }
    public bool DpeImpreso { get; set; }
    public bool DpePosteado { get; set; }
    public bool DpeEstado { get; set; }
    public decimal DpeGencnt { get; set; }
    public decimal DpeGenbnf { get; set; }
    public decimal DpeTasaPrp { get; set; }
    public decimal DpeTasaCdt { get; set; }
    public decimal DpeTasaIsc { get; set; }
    public decimal DpeTasaEsp { get; set; }
    public decimal DpeTasaAdv { get; set; }
}
