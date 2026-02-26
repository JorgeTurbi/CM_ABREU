using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBCPTLIQ")]
public class TBCPTLIQ
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("CPL_CODIGO")]
    public int CplCodigo { get; set; }

    [Column("CTA_CODIGO")]
    public string? CtaCodigo { get; set; }

    [Column("CPL_NOMBRE")]
    public required string CplNombre { get; set; }

    [Column("CPL_PASA_CXP")]
    public bool CplPasaCxp { get; set; }

    [Column("CPL_TIPO")]
    public required string CplTipo { get; set; }

    [Column("CPL_ESTADO")]
    public bool CplEstado { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }
}
