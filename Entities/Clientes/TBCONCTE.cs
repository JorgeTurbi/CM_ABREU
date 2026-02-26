using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Clientes;

[Table("TBCONCTE")]
public class TBCONCTE
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("CTE_CODIGO")]
    public required string CteCodigo { get; set; }

    [Column("CCL_CODIGO")]
    public int CclCodigo { get; set; }

    [Column("CCL_NOMBRE")]
    public required string CclNombre { get; set; }

    [Column("CCL_DIRECCION")]
    public string? CclDireccion { get; set; }

    [Column("CCL_TELEFONO")]
    public string? CclTelefono { get; set; }

    [Column("CCL_TELEFONO_EXT")]
    public string? CclTelefonoExt { get; set; }

    [Column("CCL_FAX")]
    public string? CclFax { get; set; }

    [Column("CCL_EMAIL")]
    public string? CclEmail { get; set; }

    [Column("CCL_CARGO")]
    public string? CclCargo { get; set; }

    [Column("CCL_DEFECTO")]
    public bool CclDefecto { get; set; }

    [Column("CCL_ESTADO")]
    public bool CclEstado { get; set; }
}
