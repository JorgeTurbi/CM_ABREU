namespace ApiCm.DTOs.Inventario;

public sealed class TBDETENTSALDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public required string CinTipo { get; set; }
    public int CinCodigo { get; set; }
    public int CesNumero { get; set; }
    public int DesSecuencia { get; set; }
    public int DesCompania { get; set; }
    public int AlmCodigo { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public DateTime DesFecha { get; set; }
    public decimal DesCantidad { get; set; }
    public decimal DesFactor { get; set; }
    public decimal DesCostoUnd { get; set; }
    public decimal DesPrecioUnd { get; set; }
    public bool DesImpreso { get; set; }
    public bool DesPosteado { get; set; }
    public bool DesEstado { get; set; }
    public string? DesSerie { get; set; }
}
