namespace ApiCm.DTOs;

public sealed class TBCLASEDto
{
    public int ClaCompania { get; set; }
    public int ClaCodigo { get; set; }
    public required string ClaDescripcion { get; set; }
    public int ClaEstatus { get; set; }
    public DateTime ClaFechaCrea { get; set; }
    public required string ClaUsuarioCrea { get; set; }
    public DateTime? ClaFechaMod { get; set; }
    public string? ClaUsuarioMod { get; set; }
}
