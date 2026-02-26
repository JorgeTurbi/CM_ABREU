using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBTMPENTREGA")]
public class TBTMPENTREGA
{
    [Column("TEN_COMPANIA")]
    public int TenCompania { get; set; }

    [Column("TEN_CODIGO")]
    public int TenCodigo { get; set; }

    [Column("TEN_NOMBRE")]
    public required string TenNombre { get; set; }

    [Column("TEN_ESTADO")]
    public bool TenEstado { get; set; }
}
