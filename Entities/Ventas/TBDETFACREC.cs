namespace ApiCm.Entities.Ventas;

public class TBDETFACREC
{
    public int FrcCompania { get; set; }
    public int FrcTipo { get; set; }
    public int FrcNumero { get; set; }
    public int FrcLinea { get; set; }
    public required string PrdCodigo { get; set; }
    public decimal? FrcCantidad { get; set; }
    public decimal? FrcCosto { get; set; }
    public decimal? FrcPrecio { get; set; }
    public decimal? FrcDescuento { get; set; }
    public decimal? FrcImpuesto { get; set; }
    public decimal? FrcTotal { get; set; }
    public string? FrcObservacion { get; set; }
}
