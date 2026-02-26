namespace ApiCm.DTOs.Ventas;

public sealed class TBRUTADTO
{
    public int CiaCodigo { get; set; }
    public int RutCodigo { get; set; }
    public required string RutNombre { get; set; }
    public bool RutEstado { get; set; }
}
