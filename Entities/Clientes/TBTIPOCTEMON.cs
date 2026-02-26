using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Clientes;

[Table("TBTIPOCTEMON")]
public class TBTIPOCTEMON
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("TCL_CODIGO")]
    public int TclCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("TCL_CTA_COBRAR")]
    public required string TclCtaCobrar { get; set; }

    [Column("TCL_CTA_ANTICIPO")]
    public string? TclCtaAnticipo { get; set; }
}
