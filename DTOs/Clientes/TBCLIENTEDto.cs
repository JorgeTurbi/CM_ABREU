namespace ApiCm.DTOs.Clientes;

public sealed class TBCLIENTEDto
{
    public int CiaCodigo { get; set; }
    public required string CteCodigo { get; set; }
    public int? TncCodigo { get; set; }
    public int? GctCodigo { get; set; }
    public int? CfpCodigo { get; set; }
    public int? OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public int? AuxCodigo { get; set; }
    public int? CctCodigo { get; set; }
    public int TclCodigo { get; set; }
    public int CpgCodigo { get; set; }
    public int? CclCodigo { get; set; }
    public int? LecCodigo { get; set; }
    public int PaiCodigo { get; set; }
    public int CdaCodigo { get; set; }
    public int ZnaCodigo { get; set; }
    public int? RutCodigo { get; set; }
    public int VenCodigo { get; set; }
    public int CteCompania { get; set; }
    public required string CteLocalExterior { get; set; }
    public string? CteIdiomaImp { get; set; }
    public string? CteIdioma { get; set; }
    public required string CteNegocioPersona { get; set; }
    public string? CteCodigoAlt { get; set; }
    public string? CteCodigoPrincipal { get; set; }
    public string? CteRazonSocial { get; set; }
    public required string CteNombre { get; set; }
    public string? CteDireccion { get; set; }
    public string? CteTelefono1 { get; set; }
    public string? CteTelefono1Ext { get; set; }
    public string? CteTelefono2 { get; set; }
    public string? CteTelefono2Ext { get; set; }
    public string? CteFax { get; set; }
    public string? CteEmail { get; set; }
    public string? CteWebsite { get; set; }
    public int? CteCtabcoCodigo { get; set; }
    public string? CteCtabcoTipo { get; set; }
    public string? CteCtabcoNumero { get; set; }
    public int CteCodCobrador { get; set; }
    public bool CteProspecto { get; set; }
    public bool? CteImpuesto { get; set; }
    public decimal CteDescuentoDef { get; set; }
    public required string CteTipoDescuento { get; set; }
    public string? CteCedulaRnc { get; set; }
    public decimal CteComisVen { get; set; }
    public bool CteCrUsa { get; set; }
    public bool CteCrLimiteUsa { get; set; }
    public decimal? CteCrLimiteValor { get; set; }
    public bool CteCrFacvencUsa { get; set; }
    public int? CteCrFacvencDias { get; set; }
    public DateTime? CteCrFchApertura { get; set; }
    public DateTime? CteCrFchSuspencion { get; set; }
    public DateTime? CteCrFchCancelacion { get; set; }
    public bool CteCrMoraUsa { get; set; }
    public int? CteCrMoraDias { get; set; }
    public decimal? CteCrMoraPorc { get; set; }
    public string? CteCrObservacion { get; set; }
    public required string CteCrEstado { get; set; }
    public string? CteNota { get; set; }
    public string? CteMensajeEstado { get; set; }
    public bool CteEstado { get; set; }
    public decimal CteComisCoB { get; set; }
    public DateTime? CteImpExonVence { get; set; }
}
