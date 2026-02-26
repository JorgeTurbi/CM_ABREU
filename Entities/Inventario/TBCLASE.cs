using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBCLASE")]
public class TBCLASE
{
    [Column("CLA_COMPANIA")]
    public int ClaCompania { get; set; }

    [Column("CLA_CODIGO")]
    public int ClaCodigo { get; set; }

    [Column("CIA_CODIGO")]
    public int? CiaCodigo { get; set; }

    [Column("CCT_CODIGO")]
    public int? CctCodigo { get; set; }

    [Column("CLA_NOMBRE")]
    public required string ClaNombre { get; set; }

    [Column("CLA_BGCOLOR")]
    public int? ClaBgcolor { get; set; }

    [Column("CLA_FGCOLOR")]
    public int? ClaFgcolor { get; set; }

    [Column("CLA_FOTO")]
    public byte[]? ClaFoto { get; set; }

    [Column("CLA_MOSTRAR")]
    public bool ClaMostrar { get; set; }

    [Column("CLA_ESTADO")]
    public bool ClaEstado { get; set; }
}
