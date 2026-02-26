using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.CuentasPorCobrar;

[Table("TBDOCTOCXC")]
public class TBDOCTOCXC
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

    [Column("DXC_NUMERO")]
    public int DxcNumero { get; set; }

    [Column("DXC_FORMATO_IMP")]
    public string? DxcFormatoImp { get; set; }

    [Column("DXC_ESTADO")]
    public bool DxcEstado { get; set; }
}
