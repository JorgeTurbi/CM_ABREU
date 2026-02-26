using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.CuentasPorCobrar;

[Table("TBDETMOVCXC")]
public class TBDETMOVCXC
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

    [Column("CMC_NUMERO")]
    public int CmcNumero { get; set; }

    [Column("DMC_SECUENCIA")]
    public int DmcSecuencia { get; set; }

    [Column("DMC_FECHA")]
    public DateTime DmcFecha { get; set; }

    [Column("DMC_REFERENCIA")]
    public required string DmcReferencia { get; set; }

    [Column("DMC_VALOR")]
    public decimal DmcValor { get; set; }

    [Column("DMC_IMPUESTO")]
    public decimal DmcImpuesto { get; set; }

    [Column("DMC_ESTADO")]
    public bool DmcEstado { get; set; }

    [Column("DMC_FACTURA")]
    public int DmcFactura { get; set; }
}
