namespace ApiCm.DTOs.Inventario;

public sealed class TBDETINVFISDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int CifNumero { get; set; }
    public int DifSecuencia { get; set; }
    public int DifCompania { get; set; }
    public string? DifUbicacion { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public DateTime DifFecha { get; set; }
    public decimal DifCantFisica { get; set; }
    public decimal DifCantPerpetua { get; set; }
    public decimal DifCostoUnd { get; set; }
    public bool DifImpreso { get; set; }
    public bool DifPosteado { get; set; }
    public bool DifEstado { get; set; }
    public string? DifSerie { get; set; }
}
