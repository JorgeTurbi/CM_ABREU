namespace ApiCm.DTOs.Inventario;

public sealed class TBTIPOINVDto
{
    public int TinCompania { get; set; }
    public int TinCodigo { get; set; }
    public int? CiaCodigo { get; set; }
    public string? CtaCodigo { get; set; }
    public int? CctCodigo { get; set; }
    public required string TinNombre { get; set; }
    public bool TinEstado { get; set; }
}
