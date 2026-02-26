using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.CuentasPorCobrar;

[Table("TBTIPODOCCXC")]
public class TBTIPODOCCXC
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("TDC_TIPO")]
    public required string TdcTipo { get; set; }

    [Column("TDC_CODIGO")]
    public int TdcCodigo { get; set; }

    [Column("TNC_CODIGO")]
    public int? TncCodigo { get; set; }

    [Column("TDC_NOMBRE")]
    public required string TdcNombre { get; set; }

    [Column("TDC_SIMBOLO")]
    public required string TdcSimbolo { get; set; }

    [Column("TDC_TIPO_SEC")]
    public required string TdcTipoSec { get; set; }

    [Column("TDC_FORMATO_IMP")]
    public string? TdcFormatoImp { get; set; }

    [Column("TDC_CODIGO_ED")]
    public string? TdcCodigoEd { get; set; }

    [Column("TDC_CTA_DOCTO")]
    public string? TdcCtaDocto { get; set; }

    [Column("TDC_CTA_IMP")]
    public string? TdcCtaImp { get; set; }

    [Column("TDC_CTA_DESC")]
    public string? TdcCtaDesc { get; set; }

    [Column("TDC_CTA_RET_ITBIS")]
    public string? TdcCtaRetItbis { get; set; }

    [Column("TDC_CTA_RET_ESTADO")]
    public string? TdcCtaRetEstado { get; set; }

    [Column("TDC_CTA_COMIS")]
    public string? TdcCtaComis { get; set; }

    [Column("TDC_CTA_EFECTIVO")]
    public string? TdcCtaEfectivo { get; set; }

    [Column("TDC_CTA_TARJETA")]
    public string? TdcCtaTarjeta { get; set; }

    [Column("TDC_CTA_CHEQUE")]
    public string? TdcCtaCheque { get; set; }

    [Column("TDC_CTA_DEPOSITO")]
    public string? TdcCtaDeposito { get; set; }

    [Column("TDC_CTA_NCREDITO")]
    public string? TdcCtaNcredito { get; set; }

    [Column("TDC_CTA_CUPON")]
    public string? TdcCtaCupon { get; set; }

    [Column("TDC_CTA_PERMUTA")]
    public string? TdcCtaPermuta { get; set; }

    [Column("TDC_ESTADO")]
    public bool TdcEstado { get; set; }
}
