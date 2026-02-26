namespace ApiCm.DTOs.Ventas;

public sealed class TBLUGARENVIOCTEDto
{
    public int LecCompania { get; set; }
    public int LecCodigo { get; set; }
    public required string LecDescripcion { get; set; }
    public int LecEstatus { get; set; }
    public DateTime LecFechaCrea { get; set; }
    public required string LecUsuarioCrea { get; set; }
    public DateTime? LecFechaMod { get; set; }
    public string? LecUsuarioMod { get; set; }
}
