namespace ApiCm.DTOs.Inventario;

public sealed class TBDIVISIONDto
{
    public int DivCompania { get; set; }
    public int DivCodigo { get; set; }
    public int? CiaCodigo { get; set; }
    public int? CctCodigo { get; set; }
    public required string DivNombre { get; set; }
    public bool DivEstado { get; set; }
}
