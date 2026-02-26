namespace ApiCm.DTOs.Inventario;

public sealed class TBALMACENDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int AlmCodigo { get; set; }
    public required string AlmNombre { get; set; }
    public string? AlmDireccion { get; set; }
    public string? AlmTelefono1 { get; set; }
    public string? AlmTelefono2 { get; set; }
    public string? AlmFax { get; set; }
    public string? AlmEncargado { get; set; }
    public required string AlmTipo { get; set; }
    public bool AlmUsaCompra { get; set; }
    public bool AlmUsaFactura { get; set; }
    public bool AlmEstado { get; set; }
}
