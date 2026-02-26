namespace ApiCm.DTOs.Compras;

public sealed class TBCABSOLCOTDto
{
    public long CstInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int CstNumero { get; set; }
    public int CstCompania { get; set; }
    public DateTime CstFecha { get; set; }
    public DateTime CstProceso { get; set; }
    public string? CstPrvCodigo { get; set; }
    public string? CstPrvNombre { get; set; }
    public string? CstNotaPie { get; set; }
    public required string CstElaboradoPor { get; set; }
    public required string CstGenerado { get; set; }
    public bool CstImpreso { get; set; }
    public bool CstExportado { get; set; }
    public bool CstCorreo { get; set; }
    public bool CstPosteado { get; set; }
    public bool CstNulo { get; set; }
    public bool CstEstado { get; set; }
    public string? PryCodigo { get; set; }
}
