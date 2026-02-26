using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBUNDPRCPRD")]
public class TBUNDPRCPRD
{
    [Column("UPR_COMPANIA")]
    public int UprCompania { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UPR_SECUENCIA")]
    public int UprSecuencia { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("CFP_CODIGO")]
    public int CfpCodigo { get; set; }

    [Column("UPR_PRECIO")]
    public decimal UprPrecio { get; set; }

    [Column("UPR_MARGEN")]
    public decimal? UprMargen { get; set; }

    [Column("UPR_CODIGO_BARRA")]
    public string? UprCodigoBarra { get; set; }

    [Column("UPR_ESTADO")]
    public bool UprEstado { get; set; }
}
