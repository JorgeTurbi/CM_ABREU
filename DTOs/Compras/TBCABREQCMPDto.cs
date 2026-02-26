namespace ApiCm.DTOs.Compras;

public sealed class TBCABREQCMPDto
{
    public long CrpInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int CrpNumero { get; set; }
    public int CrpCompania { get; set; }
    public int? DpnCodigo { get; set; }
    public DateTime CrpFecha { get; set; }
    public DateTime CrpProceso { get; set; }
    public string? CrpPrvCodigo { get; set; }
    public string? CrpPrvNombre { get; set; }
    public string? CrpNotaPie { get; set; }
    public required string CrpElaboradoPor { get; set; }
    public required string CrpGenerado { get; set; }
    public bool CrpImpreso { get; set; }
    public bool CrpExportado { get; set; }
    public bool CrpCorreo { get; set; }
    public bool CrpPosteado { get; set; }
    public bool CrpNulo { get; set; }
    public bool CrpEstado { get; set; }
    public string? PryCodigo { get; set; }
}
