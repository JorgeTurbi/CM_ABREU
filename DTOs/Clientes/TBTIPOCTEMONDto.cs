namespace ApiCm.DTOs.Clientes;

public sealed class TBTIPOCTEMONDto
{
    public int CiaCodigo { get; set; }
    public int TclCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TclCtaCobrar { get; set; }
    public string? TclCtaAnticipo { get; set; }
}
