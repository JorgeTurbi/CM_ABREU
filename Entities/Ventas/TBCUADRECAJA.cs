using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBCUADRECAJA")]
public class TBCUADRECAJA
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("CAJ_CODIGO")]
    public required string CajCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("CJC_FECHA")]
    public DateTime CjcFecha { get; set; }

    [Column("CJC_NOTA")]
    public string? CjcNota { get; set; }

    [Column("CJC_FONDO")]
    public decimal CjcFondo { get; set; }

    [Column("CJC_ESTADO")]
    public required string CjcEstado { get; set; }
}
