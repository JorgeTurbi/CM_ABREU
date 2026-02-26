using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Clientes;

[Table("TBTIPOCTE")]
public class TBTIPOCTE
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("TCL_CODIGO")]
    public int TclCodigo { get; set; }

    [Column("TCL_NOMBRE")]
    public required string TclNombre { get; set; }

    [Column("TCL_ESTADO")]
    public bool TclEstado { get; set; }
}
