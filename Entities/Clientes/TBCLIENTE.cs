using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Clientes;

[Table("TBCLIENTE")]
public class TBCLIENTE
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("CTE_CODIGO")]
    public required string CteCodigo { get; set; }

    [Column("TNC_CODIGO")]
    public int? TncCodigo { get; set; }

    [Column("GCT_CODIGO")]
    public int? GctCodigo { get; set; }

    [Column("CFP_CODIGO")]
    public int? CfpCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int? OfiCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("AUX_CODIGO")]
    public int? AuxCodigo { get; set; }

    [Column("CCT_CODIGO")]
    public int? CctCodigo { get; set; }

    [Column("TCL_CODIGO")]
    public int TclCodigo { get; set; }

    [Column("CPG_CODIGO")]
    public int CpgCodigo { get; set; }

    [Column("CCL_CODIGO")]
    public int? CclCodigo { get; set; }

    [Column("LEC_CODIGO")]
    public int? LecCodigo { get; set; }

    [Column("PAI_CODIGO")]
    public int PaiCodigo { get; set; }

    [Column("CDA_CODIGO")]
    public int CdaCodigo { get; set; }

    [Column("ZNA_CODIGO")]
    public int ZnaCodigo { get; set; }

    [Column("RUT_CODIGO")]
    public int? RutCodigo { get; set; }

    [Column("VEN_CODIGO")]
    public int VenCodigo { get; set; }

    [Column("CTE_COMPANIA")]
    public int CteCompania { get; set; }

    [Column("CTE_LOCAL_EXTERIOR")]
    public required string CteLocalExterior { get; set; }

    [Column("CTE_IDIOMA_IMP")]
    public string? CteIdiomaImp { get; set; }

    [Column("CTE_IDIOMA")]
    public string? CteIdioma { get; set; }

    [Column("CTE_NEGOCIO_PERSONA")]
    public required string CteNegocioPersona { get; set; }

    [Column("CTE_CODIGO_ALT")]
    public string? CteCodigoAlt { get; set; }

    [Column("CTE_CODIGO_PRINCIPAL")]
    public string? CteCodigoPrincipal { get; set; }

    [Column("CTE_RAZON_SOCIAL")]
    public string? CteRazonSocial { get; set; }

    [Column("CTE_NOMBRE")]
    public required string CteNombre { get; set; }

    [Column("CTE_DIRECCION")]
    public string? CteDireccion { get; set; }

    [Column("CTE_TELEFONO1")]
    public string? CteTelefono1 { get; set; }

    [Column("CTE_TELEFONO1_EXT")]
    public string? CteTelefono1Ext { get; set; }

    [Column("CTE_TELEFONO2")]
    public string? CteTelefono2 { get; set; }

    [Column("CTE_TELEFONO2_EXT")]
    public string? CteTelefono2Ext { get; set; }

    [Column("CTE_FAX")]
    public string? CteFax { get; set; }

    [Column("CTE_EMAIL")]
    public string? CteEmail { get; set; }

    [Column("CTE_WEBSITE")]
    public string? CteWebsite { get; set; }

    [Column("CTE_CTABCO_CODIGO")]
    public int? CteCtabcoCodigo { get; set; }

    [Column("CTE_CTABCO_TIPO")]
    public string? CteCtabcoTipo { get; set; }

    [Column("CTE_CTABCO_NUMERO")]
    public string? CteCtabcoNumero { get; set; }

    [Column("CTE_COD_COBRADOR")]
    public int CteCodCobrador { get; set; }

    [Column("CTE_PROSPECTO")]
    public bool CteProspecto { get; set; }

    [Column("CTE_IMPUESTO")]
    public bool? CteImpuesto { get; set; }

    [Column("CTE_DESCUENTO_DEF")]
    public decimal CteDescuentoDef { get; set; }

    [Column("CTE_TIPO_DESCUENTO")]
    public required string CteTipoDescuento { get; set; }

    [Column("CTE_CEDULA_RNC")]
    public string? CteCedulaRnc { get; set; }

    [Column("CTE_COMIS_VEN")]
    public decimal CteComisVen { get; set; }

    [Column("CTE_CR_USA")]
    public bool CteCrUsa { get; set; }

    [Column("CTE_CR_LIMITE_USA")]
    public bool CteCrLimiteUsa { get; set; }

    [Column("CTE_CR_LIMITE_VALOR")]
    public decimal? CteCrLimiteValor { get; set; }

    [Column("CTE_CR_FACVENC_USA")]
    public bool CteCrFacvencUsa { get; set; }

    [Column("CTE_CR_FACVENC_DIAS")]
    public int? CteCrFacvencDias { get; set; }

    [Column("CTE_CR_FCH_APERTURA")]
    public DateTime? CteCrFchApertura { get; set; }

    [Column("CTE_CR_FCH_SUSPENCION")]
    public DateTime? CteCrFchSuspencion { get; set; }

    [Column("CTE_CR_FCH_CANCELACION")]
    public DateTime? CteCrFchCancelacion { get; set; }

    [Column("CTE_CR_MORA_USA")]
    public bool CteCrMoraUsa { get; set; }

    [Column("CTE_CR_MORA_DIAS")]
    public int? CteCrMoraDias { get; set; }

    [Column("CTE_CR_MORA_PORC")]
    public decimal? CteCrMoraPorc { get; set; }

    [Column("CTE_CR_OBSERVACION")]
    public string? CteCrObservacion { get; set; }

    [Column("CTE_CR_ESTADO")]
    public required string CteCrEstado { get; set; }

    [Column("CTE_NOTA")]
    public string? CteNota { get; set; }

    [Column("CTE_MENSAJE_ESTADO")]
    public string? CteMensajeEstado { get; set; }

    [Column("CTE_ESTADO")]
    public bool CteEstado { get; set; }

    [Column("CTE_COMIS_COB")]
    public decimal CteComisCoB { get; set; }

    [Column("CTE_IMP_EXON_VENCE")]
    public DateTime? CteImpExonVence { get; set; }
}
