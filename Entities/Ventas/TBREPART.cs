using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBREPART")]
public class TBREPART
{
    [Column("REP_COMPANIA")]
    public int RepCompania { get; set; }

    [Column("REP_CODIGO")]
    public int RepCodigo { get; set; }

    [Column("REP_NOMBRE")]
    public required string RepNombre { get; set; }

    [Column("REP_TELEFONO1")]
    public string? RepTelefono1 { get; set; }

    [Column("REP_TELEFONO2")]
    public string? RepTelefono2 { get; set; }

    [Column("REP_ESTADO")]
    public bool RepEstado { get; set; }
}
