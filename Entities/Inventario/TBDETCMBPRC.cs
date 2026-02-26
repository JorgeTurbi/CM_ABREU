using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBDETCMBPRC")]
public class TBDETCMBPRC
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("CCP_NUMERO")]
    public int CcpNumero { get; set; }

    [Column("DCP_SECUENCIA")]
    public int DcpSecuencia { get; set; }

    [Column("DCP_COMPANIA")]
    public int DcpCompania { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("CFP_CODIGO")]
    public int CfpCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DCP_FECHA")]
    public DateTime DcpFecha { get; set; }

    [Column("DCP_PRECIO_ANTERIOR")]
    public decimal DcpPrecioAnterior { get; set; }

    [Column("DCP_PRECIO_NUEVO")]
    public decimal DcpPrecioNuevo { get; set; }

    [Column("DCP_IMPRESO")]
    public bool DcpImpreso { get; set; }

    [Column("DCP_POSTEADO")]
    public bool DcpPosteado { get; set; }

    [Column("DCP_ESTADO")]
    public bool DcpEstado { get; set; }
}
