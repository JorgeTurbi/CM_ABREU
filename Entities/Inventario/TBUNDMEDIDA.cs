using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBUNDMEDIDA")]
public class TBUNDMEDIDA
{
    [Column("UNM_COMPANIA")]
    public int UnmCompania { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("UNM_NOMBRE")]
    public required string UnmNombre { get; set; }

    [Column("UNM_FACTOR")]
    public decimal UnmFactor { get; set; }

    [Column("UNM_ABREVIATURA")]
    public required string UnmAbreviatura { get; set; }

    [Column("UNM_ESTADO")]
    public bool UnmEstado { get; set; }

    [Column("UNM_ECF_CODIGO")]
    public int? UnmEcfCodigo { get; set; }
}
