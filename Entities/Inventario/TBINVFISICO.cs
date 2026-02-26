using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBINVFISICO")]
public class TBINVFISICO
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("ALM_CODIGO")]
    public int AlmCodigo { get; set; }

    [Column("IFS_COMPANIA")]
    public int IfsCompania { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("IFS_CANTIDAD")]
    public decimal IfsCantidad { get; set; }

    [Column("IFS_FACTOR")]
    public decimal IfsFactor { get; set; }

    [Column("IFS_FECHA")]
    public DateTime IfsFecha { get; set; }

    [Column("IFS_ESTADO")]
    public bool IfsEstado { get; set; }
}
