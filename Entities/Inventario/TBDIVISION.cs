using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBDIVISION")]
public class TBDIVISION
{
    [Column("DIV_COMPANIA")]
    public int DivCompania { get; set; }

    [Column("DIV_CODIGO")]
    public int DivCodigo { get; set; }

    [Column("CIA_CODIGO")]
    public int? CiaCodigo { get; set; }

    [Column("CCT_CODIGO")]
    public int? CctCodigo { get; set; }

    [Column("DIV_NOMBRE")]
    public required string DivNombre { get; set; }

    [Column("DIV_ESTADO")]
    public bool DivEstado { get; set; }
}
