using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBTIPODOCVEN")]
public class TBTIPODOCVEN
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("TDV_TIPO")]
    public required string TdvTipo { get; set; }

    [Column("TDV_CODIGO")]
    public int TdvCodigo { get; set; }

    [Column("TDV_COMPANIA")]
    public int TdvCompania { get; set; }

    [Column("NDM_MODULO")]
    public required string NdmModulo { get; set; }

    [Column("NDM_CODIGO")]
    public int? NdmCodigo { get; set; }

    [Column("TNC_CODIGO")]
    public int? TncCodigo { get; set; }

    [Column("TDV_NOMBRE")]
    public required string TdvNombre { get; set; }

    [Column("TDV_SIMBOLO")]
    public required string TdvSimbolo { get; set; }

    [Column("TDV_TIPO_SEC")]
    public required string TdvTipoSec { get; set; }

    [Column("TDV_PASA_CXC")]
    public bool TdvPasaCxc { get; set; }

    [Column("TDV_USA_PRP")]
    public bool TdvUsaPrp { get; set; }

    [Column("TDV_USA_CSTPRC")]
    public string? TdvUsaCstprc { get; set; }

    [Column("TDV_APLICA_TASA")]
    public int? TdvAplicaTasa { get; set; }

    [Column("TDV_FORMATO_IMP")]
    public string? TdvFormatoImp { get; set; }

    [Column("TDV_CODIGO_ED")]
    public string? TdvCodigoEd { get; set; }

    [Column("TDV_CTA_CRD")]
    public string? TdvCtaCrd { get; set; }

    [Column("TDV_CTA_CNT")]
    public string? TdvCtaCnt { get; set; }

    [Column("TDV_CTA_DSC")]
    public string? TdvCtaDsc { get; set; }

    [Column("TDV_CTA_IMP")]
    public string? TdvCtaImp { get; set; }

    [Column("TDV_CTA_CST")]
    public string? TdvCtaCst { get; set; }

    [Column("TDV_CTA_BNF")]
    public string? TdvCtaBnf { get; set; }

    [Column("TDV_CTA_ADV")]
    public string? TdvCtaAdv { get; set; }

    [Column("TDV_CTA_ISC")]
    public string? TdvCtaIsc { get; set; }

    [Column("TDV_CTA_PRP")]
    public string? TdvCtaPrp { get; set; }

    [Column("TDV_CTA_EFECTIVO")]
    public string? TdvCtaEfectivo { get; set; }

    [Column("TDV_CTA_TARJETA")]
    public string? TdvCtaTarjeta { get; set; }

    [Column("TDV_CTA_CHEQUE")]
    public string? TdvCtaCheque { get; set; }

    [Column("TDV_CTA_DEPOSITO")]
    public string? TdvCtaDeposito { get; set; }

    [Column("TDV_CTA_NCREDITO")]
    public string? TdvCtaNcredito { get; set; }

    [Column("TDV_CTA_CUPON")]
    public string? TdvCtaCupon { get; set; }

    [Column("TDV_CTA_PERMUTA")]
    public string? TdvCtaPermuta { get; set; }

    [Column("TDV_ESTADO")]
    public bool TdvEstado { get; set; }

    [Column("TDV_CTA_REC")]
    public string? TdvCtaRec { get; set; }

    [Column("TDV_USA_EFECTIVO")]
    public bool TdvUsaEfectivo { get; set; }

    [Column("TDV_USA_TARJETA")]
    public bool TdvUsaTarjeta { get; set; }

    [Column("TDV_USA_CHEQUE")]
    public bool TdvUsaCheque { get; set; }

    [Column("TDV_USA_DEPOSITO")]
    public bool TdvUsaDeposito { get; set; }

    [Column("TDV_USA_NCREDITO")]
    public bool TdvUsaNcredito { get; set; }

    [Column("TDV_USA_CUPON")]
    public bool TdvUsaCupon { get; set; }

    [Column("TDV_USA_PERMUTA")]
    public bool TdvUsaPermuta { get; set; }

    [Column("TDV_USA_CREDITO")]
    public bool TdvUsaCredito { get; set; }

    [Column("TDV_USA_RETISR")]
    public bool TdvUsaRetisr { get; set; }

    [Column("TDV_USA_RETITB")]
    public bool TdvUsaRetitb { get; set; }

    [Column("TDV_CTA_RETISR")]
    public string? TdvCtaRetisr { get; set; }

    [Column("TDV_CTA_RETITB")]
    public string? TdvCtaRetitb { get; set; }

    [Column("TDV_CTA_CDT")]
    public string? TdvCtaCdt { get; set; }

    [Column("TDV_CTA_ESP")]
    public string? TdvCtaEsp { get; set; }
}
