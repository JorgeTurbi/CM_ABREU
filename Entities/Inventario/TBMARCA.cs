using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBMARCA")]
public class TBMARCA
{
    [Column("MAR_COMPANIA")]
    public int MarCompania { get; set; }

    [Column("MAR_CODIGO")]
    public int MarCodigo { get; set; }

    [Column("CIA_CODIGO")]
    public int? CiaCodigo { get; set; }

    [Column("CCT_CODIGO")]
    public int? CctCodigo { get; set; }

    [Column("MAR_NOMBRE")]
    public required string MarNombre { get; set; }

    [Column("MAR_ESTADO")]
    public bool MarEstado { get; set; }
}
