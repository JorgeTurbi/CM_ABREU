namespace ApiCm.DTOs.Clientes;

public sealed class TBGRPOCTEDto
{
    public int CiaCodigo { get; set; }
    public int GctCodigo { get; set; }
    public required string GctNombre { get; set; }
    public bool GctEstado { get; set; }
}
