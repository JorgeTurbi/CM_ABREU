using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBREFMULTIPLE")]
public class TBREFMULTIPLE
{
    [Column("PRD_COMPANIA")]
    public int PrdCompania { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("REF_SECUENCIA")]
    public int RefSecuencia { get; set; }

    [Column("REF_REFERENCIA")]
    public required string RefReferencia { get; set; }

    [Column("REF_ESTADO")]
    public bool RefEstado { get; set; }
}
