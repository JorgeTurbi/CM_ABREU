namespace ApiCm.DTOs.Inventario;

public sealed class TBMARCADto
{
    public int MarCompania { get; set; }
    public int MarCodigo { get; set; }
    public int? CiaCodigo { get; set; }
    public int? CctCodigo { get; set; }
    public required string MarNombre { get; set; }
    public bool MarEstado { get; set; }
}
