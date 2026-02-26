namespace ApiCm.DTOs;



public sealed class TBDIVISIONDto
{
    public int DivCompania { get; set; }
    public int DivCodigo { get; set; }
    public required string DivDescripcion { get; set; }
    public int DivEstatus { get; set; }
    public DateTime DivFechaCrea { get; set; }
    public required string DivUsuarioCrea { get; set; }
    public DateTime? DivFechaMod { get; set; }
    public string? DivUsuarioMod { get; set; }
}