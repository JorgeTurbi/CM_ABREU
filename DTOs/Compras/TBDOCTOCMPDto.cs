namespace ApiCm.DTOs.Compras;

public sealed class TBDOCTOCMPDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int DcmCompania { get; set; }
    public required string NdmModulo { get; set; }
    public int? NdmCodigo { get; set; }
    public int DcmNumero { get; set; }
    public string? DcmFormatoImp { get; set; }
    public bool DcmEstado { get; set; }
}
