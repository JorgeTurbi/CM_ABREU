using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Clientes;

[Table("TBGRPOCTE")]
public class TBGRPOCTE
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("GCT_CODIGO")]
    public int GctCodigo { get; set; }

    [Column("GCT_NOMBRE")]
    public required string GctNombre { get; set; }

    [Column("GCT_ESTADO")]
    public bool GctEstado { get; set; }
}
