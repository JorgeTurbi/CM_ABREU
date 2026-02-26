namespace ApiCm.DTOs.Compras;

public sealed class TBCABLIQMERDto
{
    public long ClqInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int ClqNumero { get; set; }
    public int ClqCompania { get; set; }
    public int CpgCodigo { get; set; }
    public required string PrvCodigo { get; set; }
    public int? CctCodigo { get; set; }
    public DateTime ClqFecha { get; set; }
    public DateTime? ClqFechaFactura { get; set; }
    public DateTime? ClqFechaRecibida { get; set; }
    public DateTime ClqProceso { get; set; }
    public int? ClqOrden { get; set; }
    public required string ClqFactura { get; set; }
    public string? ClqImportacion { get; set; }
    public decimal ClqTotalLiq { get; set; }
    public string? ClqNotaPie { get; set; }
    public required string ClqElaboradoPor { get; set; }
    public bool ClqGenerado { get; set; }
    public bool ClqImpreso { get; set; }
    public bool ClqExportado { get; set; }
    public bool ClqCorreo { get; set; }
    public bool ClqPosteado { get; set; }
    public bool ClqNulo { get; set; }
    public bool ClqEstado { get; set; }
    public string? PryCodigo { get; set; }
    public decimal? ClqMargen { get; set; }
    public decimal? ClqTasaPosteo { get; set; }
    public string? ClqEmbarque { get; set; }
    public int? ClqExpliqMon { get; set; }
    public int? ClqExpliqNum { get; set; }
}
