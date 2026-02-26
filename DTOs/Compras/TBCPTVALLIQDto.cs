namespace ApiCm.DTOs.Compras;

public sealed class TBCPTVALLIQDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public required string DcmAno { get; set; }
    public int ClqNumero { get; set; }
    public int CplCodigo { get; set; }
    public bool CvlPasaCxp { get; set; }
    public decimal CvlValor { get; set; }
    public decimal? CvlTasa { get; set; }
    public bool CvlEstado { get; set; }
}
