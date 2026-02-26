namespace ApiCm.DTOs.Compras;

public sealed class TBTIPODOCCMPDto
{
    public int CiaCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdmTipo { get; set; }
    public int TdmCodigo { get; set; }
    public int TdmCompania { get; set; }
    public required string NdmModulo { get; set; }
    public int? NdmCodigo { get; set; }
    public int? TncCodigo { get; set; }
    public required string TdmNombre { get; set; }
    public required string TdmSimbolo { get; set; }
    public required string TdmTipoSec { get; set; }
    public bool TdmPasaCxp { get; set; }
    public bool TdmAfectaInv { get; set; }
    public int? TdmAplicaTasa { get; set; }
    public string? TdmFormatoImp { get; set; }
    public string? TdmCodigoEd { get; set; }
    public string? TdmCtaCaja { get; set; }
    public string? TdmCtaImp { get; set; }
    public string? TdmCtaRetIsr { get; set; }
    public string? TdmCtaRetItb { get; set; }
    public bool TdmEstado { get; set; }
    public string? TdmCtaItbCst { get; set; }
}
