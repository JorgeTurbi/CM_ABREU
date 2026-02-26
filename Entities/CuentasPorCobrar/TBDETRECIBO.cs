using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.CuentasPorCobrar;

[Table("TBDETRECIBO")]
public class TBDETRECIBO
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("TDC_TIPO")]
    public required string TdcTipo { get; set; }

    [Column("TDC_CODIGO")]
    public int TdcCodigo { get; set; }

    [Column("DXC_ANO")]
    public required string DxcAno { get; set; }

    [Column("CRC_NUMERO")]
    public int CrcNumero { get; set; }

    [Column("DRC_SECUENCIA")]
    public int DrcSecuencia { get; set; }

    [Column("DRC_FECHA")]
    public DateTime DrcFecha { get; set; }

    [Column("DRC_REFERENCIA")]
    public required string DrcReferencia { get; set; }

    [Column("DRC_NCR_NUMERO")]
    public string? DrcNcrNumero { get; set; }

    [Column("DRC_NCR_VALOR")]
    public decimal? DrcNcrValor { get; set; }

    [Column("DRC_DESCTO_TIPO")]
    public string? DrcDesctoTipo { get; set; }

    [Column("DRC_DESCTO_PORC")]
    public decimal? DrcDesctoPorc { get; set; }

    [Column("DRC_DESCTO_VALOR")]
    public decimal? DrcDesctoValor { get; set; }

    [Column("DRC_VALOR")]
    public decimal DrcValor { get; set; }

    [Column("DRC_BALANCE")]
    public decimal DrcBalance { get; set; }

    [Column("DRC_ESTADO")]
    public bool DrcEstado { get; set; }

    [Column("DRC_NCF")]
    public string? DrcNcf { get; set; }

    [Column("DRC_ECF_NUMERO")]
    public string? DrcEcfNumero { get; set; }

    [Column("DRC_ECF_ESTADO")]
    public required string DrcEcfEstado { get; set; }

    [Column("DRC_FACTURA")]
    public int DrcFactura { get; set; }

    [Column("DRC_NCR_FACTURA")]
    public int? DrcNcrFactura { get; set; }
}
