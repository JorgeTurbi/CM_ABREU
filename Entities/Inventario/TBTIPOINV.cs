using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBTIPOINV")]
public class TBTIPOINV
{
    [Column("TIN_COMPANIA")]
    public int TinCompania { get; set; }

    [Column("TIN_CODIGO")]
    public int TinCodigo { get; set; }

    [Column("CIA_CODIGO")]
    public int? CiaCodigo { get; set; }

    [Column("CTA_CODIGO")]
    public string? CtaCodigo { get; set; }

    [Column("CCT_CODIGO")]
    public int? CctCodigo { get; set; }

    [Column("TIN_NOMBRE")]
    public required string TinNombre { get; set; }

    [Column("TIN_ESTADO")]
    public bool TinEstado { get; set; }
}
