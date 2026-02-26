using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBCFGPRECIO")]
public class TBCFGPRECIO
{
    [Column("CFP_COMPANIA")]
    public int CfpCompania { get; set; }

    [Column("CFP_CODIGO")]
    public int CfpCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("CFP_NOMBRE")]
    public required string CfpNombre { get; set; }

    [Column("CFP_TIPO")]
    public required string CfpTipo { get; set; }

    [Column("CFP_SOLO_MAYOR")]
    public bool CfpSoloMayor { get; set; }

    [Column("CFP_MARGEN")]
    public decimal? CfpMargen { get; set; }

    [Column("CFP_ESTADO")]
    public bool CfpEstado { get; set; }

    [Column("CFP_MODO")]
    public string? CfpModo { get; set; }

    [Column("CFP_CODIGO_BASE")]
    public int? CfpCodigoBase { get; set; }
}
