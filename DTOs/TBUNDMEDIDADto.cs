
namespace ApiCm.DTOs;

public sealed class TBUNDMEDIDADto
{
    public int UnmCompania { get; set; }
    public int UnmCodigo { get; set; }
    public required string UnmDescripcion { get; set; }
    public int UnmEstatus { get; set; }
    public DateTime UnmFechaCrea { get; set; }
    public required string UnmUsuarioCrea { get; set; }
    public DateTime? UnmFechaMod { get; set; }
    public string? UnmUsuarioMod { get; set; }
}