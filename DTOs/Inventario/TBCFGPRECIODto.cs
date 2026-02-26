namespace ApiCm.DTOs.Inventario;

public sealed class TBCFGPRECIODto
{
    public int CfpCompania { get; set; }
    public int CfpCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string CfpNombre { get; set; }
    public required string CfpTipo { get; set; }
    public bool CfpSoloMayor { get; set; }
    public decimal? CfpMargen { get; set; }
    public bool CfpEstado { get; set; }
    public string? CfpModo { get; set; }
    public int? CfpCodigoBase { get; set; }
}
