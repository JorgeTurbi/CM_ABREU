using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBVALDNMCUADRE")]
public class TBVALDNMCUADRE
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("CAJ_CODIGO")]
    public required string CajCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("CJC_FECHA")]
    public DateTime CjcFecha { get; set; }

    [Column("DNM_CODIGO")]
    public int DnmCodigo { get; set; }

    [Column("CJD_VALOR")]
    public decimal CjdValor { get; set; }

    [Column("CJD_ESTADO")]
    public bool CjdEstado { get; set; }
}
