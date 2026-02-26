namespace ApiCm.DTOs.Ventas;

public sealed class TBTIPODOCVENDTO
{
    public int CiaCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdvTipo { get; set; }
    public int TdvCodigo { get; set; }
    public int TdvCompania { get; set; }
    public required string NdmModulo { get; set; }
    public int? NdmCodigo { get; set; }
    public int? TncCodigo { get; set; }
    public required string TdvNombre { get; set; }
    public required string TdvSimbolo { get; set; }
    public required string TdvTipoSec { get; set; }
    public bool TdvPasaCxc { get; set; }
    public bool TdvUsaPrp { get; set; }
    public string? TdvUsaCstprc { get; set; }
    public int? TdvAplicaTasa { get; set; }
    public string? TdvFormatoImp { get; set; }
    public string? TdvCodigoEd { get; set; }
    public string? TdvCtaCrd { get; set; }
    public string? TdvCtaCnt { get; set; }
    public string? TdvCtaDsc { get; set; }
    public string? TdvCtaImp { get; set; }
    public string? TdvCtaCst { get; set; }
    public string? TdvCtaBnf { get; set; }
    public string? TdvCtaAdv { get; set; }
    public string? TdvCtaIsc { get; set; }
    public string? TdvCtaPrp { get; set; }
    public string? TdvCtaEfectivo { get; set; }
    public string? TdvCtaTarjeta { get; set; }
    public string? TdvCtaCheque { get; set; }
    public string? TdvCtaDeposito { get; set; }
    public string? TdvCtaNcredito { get; set; }
    public string? TdvCtaCupon { get; set; }
    public string? TdvCtaPermuta { get; set; }
    public bool TdvEstado { get; set; }
    public string? TdvCtaRec { get; set; }
    public bool TdvUsaEfectivo { get; set; }
    public bool TdvUsaTarjeta { get; set; }
    public bool TdvUsaCheque { get; set; }
    public bool TdvUsaDeposito { get; set; }
    public bool TdvUsaNcredito { get; set; }
    public bool TdvUsaCupon { get; set; }
    public bool TdvUsaPermuta { get; set; }
    public bool TdvUsaCredito { get; set; }
    public bool TdvUsaRetisr { get; set; }
    public bool TdvUsaRetitb { get; set; }
    public string? TdvCtaRetisr { get; set; }
    public string? TdvCtaRetitb { get; set; }
    public string? TdvCtaCdt { get; set; }
    public string? TdvCtaEsp { get; set; }
}
