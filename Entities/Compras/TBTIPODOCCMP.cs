using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBTIPODOCCMP")]
public class TBTIPODOCCMP
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("TDM_TIPO")]
    public required string TdmTipo { get; set; }

    [Column("TDM_CODIGO")]
    public int TdmCodigo { get; set; }

    [Column("TDM_COMPANIA")]
    public int TdmCompania { get; set; }

    [Column("NDM_MODULO")]
    public required string NdmModulo { get; set; }

    [Column("NDM_CODIGO")]
    public int? NdmCodigo { get; set; }

    [Column("TNC_CODIGO")]
    public int? TncCodigo { get; set; }

    [Column("TDM_NOMBRE")]
    public required string TdmNombre { get; set; }

    [Column("TDM_SIMBOLO")]
    public required string TdmSimbolo { get; set; }

    [Column("TDM_TIPO_SEC")]
    public required string TdmTipoSec { get; set; }

    [Column("TDM_PASA_CXP")]
    public bool TdmPasaCxp { get; set; }

    [Column("TDM_AFECTA_INV")]
    public bool TdmAfectaInv { get; set; }

    [Column("TDM_APLICA_TASA")]
    public int? TdmAplicaTasa { get; set; }

    [Column("TDM_FORMATO_IMP")]
    public string? TdmFormatoImp { get; set; }

    [Column("TDM_CODIGO_ED")]
    public string? TdmCodigoEd { get; set; }

    [Column("TDM_CTA_CAJA")]
    public string? TdmCtaCaja { get; set; }

    [Column("TDM_CTA_IMP")]
    public string? TdmCtaImp { get; set; }

    [Column("TDM_CTA_RET_ISR")]
    public string? TdmCtaRetIsr { get; set; }

    [Column("TDM_CTA_RET_ITB")]
    public string? TdmCtaRetItb { get; set; }

    [Column("TDM_ESTADO")]
    public bool TdmEstado { get; set; }

    [Column("TDM_CTA_ITB_CST")]
    public string? TdmCtaItbCst { get; set; }
}
