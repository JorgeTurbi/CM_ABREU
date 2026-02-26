using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Clientes;

[Table("TBCIUDAD")]
public class TBCIUDAD
{
    [Key]
    [Column("CDA_CODIGO")]
    public int CdaCodigo { get; set; }

    [Column("CDA_NOMBRE")]
    public required string CdaNombre { get; set; }

    [Column("CDA_ESTADO")]
    public bool CdaEstado { get; set; }
}
