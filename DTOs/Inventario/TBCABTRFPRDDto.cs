namespace ApiCm.DTOs.Inventario;

public sealed class TBCABTRFPRDDto
{
    public long CtpInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int CtpNumero { get; set; }
    public int CtpCompania { get; set; }
    public int CtpOfiDestino { get; set; }
    public int CtpAlmOrigen { get; set; }
    public int CtpAlmDestino { get; set; }
    public string? CtpDocumento { get; set; }
    public DateTime CtpFecha { get; set; }
    public DateTime CtpProceso { get; set; }
    public string? CtpConcepto { get; set; }
    public required string CtpElaboradoPor { get; set; }
    public string? CtpRecibidoPor { get; set; }
    public DateTime? CtpRecibido { get; set; }
    public decimal CtpTotal { get; set; }
    public bool CtpImpreso { get; set; }
    public bool CtpExportado { get; set; }
    public bool CtpCorreo { get; set; }
    public bool CtpPosteado { get; set; }
    public bool CtpNulo { get; set; }
    public bool CtpEstado { get; set; }
    public string? PryCodigo { get; set; }
    public int? TrpCodigo { get; set; }
}
