namespace ApiCm.DTOs.Clientes;

public sealed class TBCTEDEFECTODto
{
    public int CiaCodigo { get; set; }
    public required string CdfLocalExterior { get; set; }
    public int CdfCompania { get; set; }
    public int? PaiCodigo { get; set; }
    public int? CfpCodigo { get; set; }
    public int? CdaCodigo { get; set; }
    public int? ZnaCodigo { get; set; }
    public int? VenCodigo { get; set; }
    public int? CpgCodigo { get; set; }
    public int? MonCodigo { get; set; }
    public int? RutCodigo { get; set; }
    public int? TclCodigo { get; set; }
    public int? OfiCodigo { get; set; }
    public int? CdfCodCobrador { get; set; }
    public string? CdfNegocioPersona { get; set; }
    public string? CdfIdiomaImp { get; set; }
    public string? CdfIdioma { get; set; }
    public bool? CdfImpuesto { get; set; }
    public bool CdfCrUsa { get; set; }
    public int? TncCodigo { get; set; }
    public decimal? CdfDescuentoDef { get; set; }
    public string? CdfTipoDescuento { get; set; }
    public bool CdfCrLimiteUsa { get; set; }
    public decimal? CdfCrLimiteValor { get; set; }
    public bool CdfCrMoraUsa { get; set; }
    public int? CdfCrMoraDias { get; set; }
    public decimal? CdfCrMoraPorc { get; set; }
    public bool CdfCrFacvencUsa { get; set; }
    public int? CdfCrFacvencDias { get; set; }
    public string? CdfMensajeEstado { get; set; }
    public bool CdfEstado { get; set; }
}
