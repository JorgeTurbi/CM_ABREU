namespace ApiCm.DTOs.Inventario;

public sealed class TBCPTINVDto
{
    public int CiaCodigo { get; set; }
    public required string CinTipo { get; set; }
    public int CinCodigo { get; set; }
    public int? CinCompania { get; set; }
    public string? CtaCodigo { get; set; }
    public int? CfpCodigo { get; set; }
    public required string CinNombre { get; set; }
    public int CinNumero { get; set; }
    public string? CinCstprc { get; set; }
    public bool CinEstado { get; set; }
}
