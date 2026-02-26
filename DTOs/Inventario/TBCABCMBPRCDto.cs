namespace ApiCm.DTOs.Inventario;

public sealed class TBCABCMBPRCDto
{
    public long CcpInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int CcpNumero { get; set; }
    public int CcpCompania { get; set; }
    public string? CcpDocumento { get; set; }
    public DateTime CcpFecha { get; set; }
    public string? CcpConcepto { get; set; }
    public required string CcpElaboradoPor { get; set; }
    public DateTime CcpProceso { get; set; }
    public bool CcpImpreso { get; set; }
    public bool CcpExportado { get; set; }
    public bool CcpCorreo { get; set; }
    public bool CcpPosteado { get; set; }
    public bool CcpNulo { get; set; }
    public bool CcpEstado { get; set; }
}
