namespace ApiCm.DTOs.Inventario;

public sealed class TBCLASEDto
{
    public int ClaCompania { get; set; }
    public int ClaCodigo { get; set; }
    public int? CiaCodigo { get; set; }
    public int? CctCodigo { get; set; }
    public required string ClaNombre { get; set; }
    public int? ClaBgcolor { get; set; }
    public int? ClaFgcolor { get; set; }
    public byte[]? ClaFoto { get; set; }
    public bool ClaMostrar { get; set; }
    public bool ClaEstado { get; set; }
}
