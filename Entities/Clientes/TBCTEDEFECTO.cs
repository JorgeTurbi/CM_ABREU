using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Clientes;

[Table("TBCTEDEFECTO")]
public class TBCTEDEFECTO
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("CDF_LOCAL_EXTERIOR")]
    public required string CdfLocalExterior { get; set; }

    [Column("CDF_COMPANIA")]
    public int CdfCompania { get; set; }

    [Column("PAI_CODIGO")]
    public int? PaiCodigo { get; set; }

    [Column("CFP_CODIGO")]
    public int? CfpCodigo { get; set; }

    [Column("CDA_CODIGO")]
    public int? CdaCodigo { get; set; }

    [Column("ZNA_CODIGO")]
    public int? ZnaCodigo { get; set; }

    [Column("VEN_CODIGO")]
    public int? VenCodigo { get; set; }

    [Column("CPG_CODIGO")]
    public int? CpgCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int? MonCodigo { get; set; }

    [Column("RUT_CODIGO")]
    public int? RutCodigo { get; set; }

    [Column("TCL_CODIGO")]
    public int? TclCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int? OfiCodigo { get; set; }

    [Column("CDF_COD_COBRADOR")]
    public int? CdfCodCobrador { get; set; }

    [Column("CDF_NEGOCIO_PERSONA")]
    public string? CdfNegocioPersona { get; set; }

    [Column("CDF_IDIOMA_IMP")]
    public string? CdfIdiomaImp { get; set; }

    [Column("CDF_IDIOMA")]
    public string? CdfIdioma { get; set; }

    [Column("CDF_IMPUESTO")]
    public bool? CdfImpuesto { get; set; }

    [Column("CDF_CR_USA")]
    public bool CdfCrUsa { get; set; }

    [Column("TNC_CODIGO")]
    public int? TncCodigo { get; set; }

    [Column("CDF_DESCUENTO_DEF")]
    public decimal? CdfDescuentoDef { get; set; }

    [Column("CDF_TIPO_DESCUENTO")]
    public string? CdfTipoDescuento { get; set; }

    [Column("CDF_CR_LIMITE_USA")]
    public bool CdfCrLimiteUsa { get; set; }

    [Column("CDF_CR_LIMITE_VALOR")]
    public decimal? CdfCrLimiteValor { get; set; }

    [Column("CDF_CR_MORA_USA")]
    public bool CdfCrMoraUsa { get; set; }

    [Column("CDF_CR_MORA_DIAS")]
    public int? CdfCrMoraDias { get; set; }

    [Column("CDF_CR_MORA_PORC")]
    public decimal? CdfCrMoraPorc { get; set; }

    [Column("CDF_CR_FACVENC_USA")]
    public bool CdfCrFacvencUsa { get; set; }

    [Column("CDF_CR_FACVENC_DIAS")]
    public int? CdfCrFacvencDias { get; set; }

    [Column("CDF_MENSAJE_ESTADO")]
    public string? CdfMensajeEstado { get; set; }

    [Column("CDF_ESTADO")]
    public bool CdfEstado { get; set; }
}
