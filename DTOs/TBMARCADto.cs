namespace ApiCm.DTOs;

public sealed class TBMARCADto
{
    public int MarCompania { get; set; }
    public int MarCodigo { get; set; }
    public required string MarDescripcion { get; set; }
    public int MarEstatus { get; set; }
    public DateTime MarFechaCrea { get; set; }
    public required string MarUsuarioCrea { get; set; }
    public DateTime? MarFechaMod { get; set; }
    public string? MarUsuarioMod { get; set; }
}