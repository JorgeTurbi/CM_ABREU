namespace ApiCm.DTOs.Compras;

public sealed class TBCPTLIQDto
{
    public int CiaCodigo { get; set; }
    public int CplCodigo { get; set; }
    public string? CtaCodigo { get; set; }
    public required string CplNombre { get; set; }
    public bool CplPasaCxp { get; set; }
    public required string CplTipo { get; set; }
    public bool CplEstado { get; set; }
    public int MonCodigo { get; set; }
}
