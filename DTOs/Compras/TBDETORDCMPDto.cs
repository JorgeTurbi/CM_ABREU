namespace ApiCm.DTOs.Compras;

public sealed class TBDETORDCMPDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int CocNumero { get; set; }
    public int DocSecuencia { get; set; }
    public int DocCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public string? DocPrdNombre { get; set; }
    public DateTime DocFecha { get; set; }
    public decimal DocCantidad { get; set; }
    public decimal DocFactor { get; set; }
    public decimal DocCostoUnd { get; set; }
    public bool DocImpUsa { get; set; }
    public decimal? DocImpPorc { get; set; }
    public decimal DocDescPorc { get; set; }
    public string? DocNota { get; set; }
    public bool DocImpreso { get; set; }
    public bool DocPosteado { get; set; }
    public bool DocEstado { get; set; }
    public decimal DocGencnt { get; set; }
    public decimal DocBonificado { get; set; }
    public decimal DocGenbnf { get; set; }
}
