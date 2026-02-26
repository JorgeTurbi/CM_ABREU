namespace ApiCm.DTOs;

public sealed class TBPRDALMDto
{
    public int PrdCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int AlmCodigo { get; set; }
    public decimal? PrdExistencia { get; set; }
    public decimal? PrdDisponible { get; set; }
    public decimal? PrdComprometido { get; set; }
    public decimal? PrdMaximo { get; set; }
    public decimal? PrdMinimo { get; set; }
    public decimal? PrdReorden { get; set; }
    public DateTime? PrdFechaUltMov { get; set; }
    public DateTime? PrdFechaUltInv { get; set; }
    public DateTime? PrdFechaUltCst { get; set; }
    public decimal? PrdCostoProm { get; set; }
    public decimal? PrdCostoUlt { get; set; }
    public decimal? PrdCostoAnt { get; set; }
    public decimal? PrdCostoAct { get; set; }
    public string? PrdUbicacion { get; set; }
    public string? PrdObservacion { get; set; }
    public DateTime? PrdFechaCrea { get; set; }
    public string? PrdUsuarioCrea { get; set; }
    public DateTime? PrdFechaMod { get; set; }
    public string? PrdUsuarioMod { get; set; }
}