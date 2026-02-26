namespace ApiCm.DTOs.Ventas;

public sealed class TBCUADRECAJADTO
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public required string CajCodigo { get; set; }
    public int MonCodigo { get; set; }
    public DateTime CjcFecha { get; set; }
    public string? CjcNota { get; set; }
    public decimal CjcFondo { get; set; }
    public required string CjcEstado { get; set; }
}
