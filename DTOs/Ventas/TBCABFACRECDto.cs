namespace ApiCm.DTOs.Ventas;

public sealed class TBCABFACRECDto
{
    public int FrcCompania { get; set; }
    public int FrcTipo { get; set; }
    public int FrcNumero { get; set; }
    public DateTime FrcFecha { get; set; }
    public int? CteCodigo { get; set; }
    public int? FrcEstatus { get; set; }
    public decimal? FrcSubtotal { get; set; }
    public decimal? FrcDescuento { get; set; }
    public decimal? FrcImpuesto { get; set; }
    public decimal? FrcTotal { get; set; }
    public string? FrcObservacion { get; set; }
    public DateTime? FrcFechaCrea { get; set; }
    public string? FrcUsuarioCrea { get; set; }
    public DateTime? FrcFechaMod { get; set; }
    public string? FrcUsuarioMod { get; set; }
}
