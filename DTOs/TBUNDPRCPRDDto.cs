namespace ApiCm.DTOs;

public sealed class TBUNDPRCPRDDto
{
    public int PrdCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int? UnmCodigo { get; set; }
    public int? PrcCodigo { get; set; }
    public decimal? UndFactor { get; set; }
    public decimal? UndPrecio { get; set; }
    public decimal? UndCosto { get; set; }
    public int? UndEstatus { get; set; }
    public DateTime? UndFechaCrea { get; set; }
    public string? UndUsuarioCrea { get; set; }
    public DateTime? UndFechaMod { get; set; }
    public string? UndUsuarioMod { get; set; }
}