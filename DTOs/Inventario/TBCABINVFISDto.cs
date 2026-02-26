namespace ApiCm.DTOs.Inventario;

public sealed class TBCABINVFISDto
{
    public long CifInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int CifNumero { get; set; }
    public int CifCompania { get; set; }
    public int AlmCodigo { get; set; }
    public string? CifDocumento { get; set; }
    public DateTime CifFecha { get; set; }
    public string? CifConcepto { get; set; }
    public required string CifElaboradoPor { get; set; }
    public DateTime CifProceso { get; set; }
    public bool CifImpreso { get; set; }
    public bool CifExportado { get; set; }
    public bool CifCorreo { get; set; }
    public bool CifPosteado { get; set; }
    public bool CifNulo { get; set; }
    public bool CifEstado { get; set; }
    public string? CifEntTipo { get; set; }
    public int? CifEntCodigo { get; set; }
    public int? CifEntNumero { get; set; }
    public string? CifSalTipo { get; set; }
    public int? CifSalCodigo { get; set; }
    public int? CifSalNumero { get; set; }
}
