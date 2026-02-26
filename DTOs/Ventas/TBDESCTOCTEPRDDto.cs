namespace ApiCm.DTOs.Ventas;

public sealed class TBDESCTOCTEPRDDTO
{
    public int CiaCodigo { get; set; }
    public required string CteCodigo { get; set; }
    public int MonCodigo { get; set; }
    public int DspSecuencia { get; set; }
    public int DspCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public string? DspPrdNombre { get; set; }
    public required string DspTipo { get; set; }
    public decimal DspValor { get; set; }
    public string? DspServicio { get; set; }
    public bool DspEstado { get; set; }
}
