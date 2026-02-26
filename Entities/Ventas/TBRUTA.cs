using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBRUTA")]
public class TBRUTA
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("RUT_CODIGO")]
    public int RutCodigo { get; set; }

    [Column("RUT_NOMBRE")]
    public required string RutNombre { get; set; }

    [Column("RUT_ESTADO")]
    public bool RutEstado { get; set; }
}
