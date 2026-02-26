using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBVALCPTCUADRE")]
public class TBVALCPTCUADRE
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

    [Column("CJC_CODIGO")]
    public int CjcCodigo { get; set; }

    [Column("CJT_VALOR")]
    public decimal CjtValor { get; set; }

    [Column("CJT_ESTADO")]
    public bool CjtEstado { get; set; }
}
