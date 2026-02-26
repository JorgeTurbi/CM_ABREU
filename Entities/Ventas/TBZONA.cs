using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBZONA")]
public class TBZONA
{
    [Column("ZNA_CODIGO")]
    public int ZnaCodigo { get; set; }

    [Column("ZNA_NOMBRE")]
    public required string ZnaNombre { get; set; }

    [Column("ZNA_ESTADO")]
    public bool ZnaEstado { get; set; }
}
