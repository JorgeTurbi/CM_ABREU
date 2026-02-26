namespace ApiCm.DTOs.Clientes;

public sealed class TBTIPOCTEDto
{
    public int CiaCodigo { get; set; }
    public int TclCodigo { get; set; }
    public required string TclNombre { get; set; }
    public bool TclEstado { get; set; }
}
