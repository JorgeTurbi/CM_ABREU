namespace ApiCm.DTOs.Clientes;

public sealed class TBCONCTEDto
{
    public int CiaCodigo { get; set; }
    public required string CteCodigo { get; set; }
    public int CclCodigo { get; set; }
    public required string CclNombre { get; set; }
    public string? CclDireccion { get; set; }
    public string? CclTelefono { get; set; }
    public string? CclTelefonoExt { get; set; }
    public string? CclFax { get; set; }
    public string? CclEmail { get; set; }
    public string? CclCargo { get; set; }
    public bool CclDefecto { get; set; }
    public bool CclEstado { get; set; }
}
