namespace ApiCm.DTOs.Inventario;

public sealed class TBUNDPRCPRDDto
{
    public int UprCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int UprSecuencia { get; set; }
    public int UnmCodigo { get; set; }
    public int CfpCodigo { get; set; }
    public decimal UprPrecio { get; set; }
    public decimal? UprMargen { get; set; }
    public string? UprCodigoBarra { get; set; }
    public bool UprEstado { get; set; }
}
