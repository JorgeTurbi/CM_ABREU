using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBNOTADOCTO")]
public class TBNOTADOCTO
{
    [Column("NDM_COMPANIA")]
    public int NdmCompania { get; set; }

    [Column("NDM_MODULO")]
    public required string NdmModulo { get; set; }

    [Column("NDM_CODIGO")]
    public int NdmCodigo { get; set; }

    [Column("NDM_NOTA_PIE")]
    public string? NdmNotaPie { get; set; }

    [Column("NDM_NOTA_2")]
    public string? NdmNota2 { get; set; }

    [Column("NDM_TIPO")]
    public required string NdmTipo { get; set; }

    [Column("NDM_DEFECTO")]
    public bool NdmDefecto { get; set; }

    [Column("NDM_ESTADO")]
    public bool NdmEstado { get; set; }
}
