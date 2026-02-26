namespace ApiCm.DTOs.Compras;

public sealed class TBDETLIQMERDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int ClqNumero { get; set; }
    public int DlqSecuencia { get; set; }
    public int DlqCompania { get; set; }
    public int AlmCodigo { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public string? DlqPrdNombre { get; set; }
    public DateTime DlqFecha { get; set; }
    public decimal DlqCantidad { get; set; }
    public decimal DlqFactor { get; set; }
    public decimal DlqPeso { get; set; }
    public decimal DlqCostoUnd { get; set; }
    public decimal DlqImpAduana { get; set; }
    public string? DlqNota { get; set; }
    public bool DlqImpreso { get; set; }
    public bool DlqPosteado { get; set; }
    public bool DlqEstado { get; set; }
    public string? DlqSerie { get; set; }
}
