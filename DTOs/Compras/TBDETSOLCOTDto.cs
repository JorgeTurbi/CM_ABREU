namespace ApiCm.DTOs.Compras;

public sealed class TBDETSOLCOTDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int CstNumero { get; set; }
    public int DstSecuencia { get; set; }
    public int DstCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public string? DstPrdNombre { get; set; }
    public decimal DstCantidad { get; set; }
    public decimal DstFactor { get; set; }
    public string? DstNota { get; set; }
    public bool DstImpreso { get; set; }
    public bool DstPosteado { get; set; }
    public bool DstEstado { get; set; }
    public decimal DstGencnt { get; set; }
    public decimal DstBonificado { get; set; }
    public decimal DstGenbnf { get; set; }
}
