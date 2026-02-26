namespace ApiCm.DTOs.Compras;

public sealed class TBDETREQCMPDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int CrpNumero { get; set; }
    public int DrpSecuencia { get; set; }
    public int DrpCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public string? DrpPrdNombre { get; set; }
    public decimal DrpCantidad { get; set; }
    public decimal DrpFactor { get; set; }
    public string? DrpNota { get; set; }
    public bool DrpImpreso { get; set; }
    public bool DrpPosteado { get; set; }
    public bool DrpEstado { get; set; }
    public decimal DrpGencnt { get; set; }
    public decimal DrpBonificado { get; set; }
    public decimal DrpGenbnf { get; set; }
}
