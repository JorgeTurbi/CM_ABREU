namespace ApiCm.DTOs.Compras;

public sealed class TBCABORDCMPDto
{
    public long CocInternoNo { get; set; }
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int CocNumero { get; set; }
    public int CocCompania { get; set; }
    public int CpgCodigo { get; set; }
    public int? LepCodigo { get; set; }
    public int? EnvCodigo { get; set; }
    public string? CteCodigo { get; set; }
    public DateTime CocFecha { get; set; }
    public DateTime? CocFechaEmbarque { get; set; }
    public DateTime? CocFechaEntrega { get; set; }
    public DateTime CocProceso { get; set; }
    public string? CocPrvCodigo { get; set; }
    public string? CocPrvNombre { get; set; }
    public string? CocPrvReferencia { get; set; }
    public string? CocCteOrden { get; set; }
    public decimal CocDescPorc { get; set; }
    public bool CocImpUsa { get; set; }
    public decimal? CocImpPorc { get; set; }
    public decimal CocValorBruto { get; set; }
    public decimal CocValorDescuento { get; set; }
    public decimal CocValorImpuesto { get; set; }
    public decimal CocValorFlete { get; set; }
    public decimal CocValorSeguro { get; set; }
    public decimal CocValorOtro { get; set; }
    public decimal? CocTasa { get; set; }
    public string? CocNotaPie { get; set; }
    public required string CocElaboradoPor { get; set; }
    public required string CocGenerado { get; set; }
    public bool CocImpreso { get; set; }
    public bool CocExportado { get; set; }
    public bool CocCorreo { get; set; }
    public bool CocPosteado { get; set; }
    public bool CocNulo { get; set; }
    public bool CocEstado { get; set; }
    public string? PryCodigo { get; set; }
}
