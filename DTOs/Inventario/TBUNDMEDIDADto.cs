namespace ApiCm.DTOs.Inventario;

public sealed class TBUNDMEDIDADto
{
    public int UnmCompania { get; set; }
    public int UnmCodigo { get; set; }
    public required string UnmNombre { get; set; }
    public decimal UnmFactor { get; set; }
    public required string UnmAbreviatura { get; set; }
    public bool UnmEstado { get; set; }
    public int? UnmEcfCodigo { get; set; }
}
