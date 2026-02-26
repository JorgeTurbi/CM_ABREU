namespace ApiCm.DTOs.CuentasPorCobrar;

public sealed class TBDOCTOCXCDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdcTipo { get; set; }
    public int TdcCodigo { get; set; }
    public required string DxcAno { get; set; }
    public int DxcNumero { get; set; }
    public string? DxcFormatoImp { get; set; }
    public bool DxcEstado { get; set; }
}
