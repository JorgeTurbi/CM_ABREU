namespace ApiCm.DTOs.Inventario;

public sealed class TBCABENTSALDto
{
    public long CesInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public required string CinTipo { get; set; }
    public int CinCodigo { get; set; }
    public int CesNumero { get; set; }
    public int? DpnCodigo { get; set; }
    public int CesCompania { get; set; }
    public string? CesDocumento { get; set; }
    public DateTime CesFecha { get; set; }
    public DateTime CesProceso { get; set; }
    public string? CesConcepto { get; set; }
    public decimal CesTotal { get; set; }
    public required string CesElaboradoPor { get; set; }
    public bool CesImpreso { get; set; }
    public bool CesExportado { get; set; }
    public bool CesCorreo { get; set; }
    public bool CesPosteado { get; set; }
    public bool CesNulo { get; set; }
    public bool CesEstado { get; set; }
    public string? PryCodigo { get; set; }
}
