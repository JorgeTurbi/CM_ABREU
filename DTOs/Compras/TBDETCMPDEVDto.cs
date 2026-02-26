namespace ApiCm.DTOs.Compras;

public sealed class TBDETCMPDEVDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int CcdNumero { get; set; }
    public int DcdSecuencia { get; set; }
    public int DcdCompania { get; set; }
    public int AlmCodigo { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public string? DcdPrdNombre { get; set; }
    public DateTime DcdFecha { get; set; }
    public decimal DcdCantidad { get; set; }
    public decimal DcdFactor { get; set; }
    public decimal DcdCostoUnd { get; set; }
    public bool DcdImpUsa { get; set; }
    public decimal? DcdImpPorc { get; set; }
    public decimal DcdDescPorc { get; set; }
    public string? DcdNota { get; set; }
    public bool DcdImpreso { get; set; }
    public bool DcdPosteado { get; set; }
    public bool DcdEstado { get; set; }
    public decimal DcdGencnt { get; set; }
    public decimal DcdBonificado { get; set; }
    public decimal DcdGenbnf { get; set; }
    public string? DcdSerie { get; set; }
}
