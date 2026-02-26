using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBDOCTOVEN")]
public class TBDOCTOVEN
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("TDV_TIPO")]
    public required string TdvTipo { get; set; }

    [Column("TDV_CODIGO")]
    public int TdvCodigo { get; set; }

    [Column("DNV_ANO")]
    public required string DnvAno { get; set; }

    [Column("DNV_COMPANIA")]
    public int DnvCompania { get; set; }

    [Column("NDM_MODULO")]
    public required string NdmModulo { get; set; }

    [Column("NDM_CODIGO")]
    public int? NdmCodigo { get; set; }

    [Column("TNC_CODIGO")]
    public int? TncCodigo { get; set; }

    [Column("DNV_NUMERO")]
    public int DnvNumero { get; set; }

    [Column("DNV_USA_PRP")]
    public bool DnvUsaPrp { get; set; }

    [Column("DNV_FORMATO_IMP")]
    public string? DnvFormatoImp { get; set; }

    [Column("DNV_ESTADO")]
    public bool DnvEstado { get; set; }
}
