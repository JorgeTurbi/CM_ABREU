using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBLUGARENVCMP")]
public class TBLUGARENVCMP
{
    [Column("LEP_COMPANIA")]
    public int LepCompania { get; set; }

    [Column("LEP_CODIGO")]
    public int LepCodigo { get; set; }

    [Column("LEP_NOMBRE")]
    public required string LepNombre { get; set; }

    [Column("LEP_DIRECCION")]
    public string? LepDireccion { get; set; }

    [Column("LEP_TELEFONO")]
    public string? LepTelefono { get; set; }

    [Column("LEP_CONTACTO")]
    public string? LepContacto { get; set; }

    [Column("LEP_ESTADO")]
    public bool LepEstado { get; set; }
}
