
namespace ApiCm.DTOs;

public sealed class TBTIPOINVDto
{
    public int TinCompania { get; set; }
    public int TinCodigo { get; set; }
    public required string TinDescripcion { get; set; }
    public int TinEstatus { get; set; }
    public DateTime TinFechaCrea { get; set; }
    public required string TinUsuarioCrea { get; set; }
    public DateTime? TinFechaMod { get; set; }
    public string? TinUsuarioMod { get; set; }
}