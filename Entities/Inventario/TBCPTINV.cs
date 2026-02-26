using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBCPTINV")]
public class TBCPTINV
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("CIN_TIPO")]
    public required string CinTipo { get; set; }

    [Column("CIN_CODIGO")]
    public int CinCodigo { get; set; }

    [Column("CIN_COMPANIA")]
    public int? CinCompania { get; set; }

    [Column("CTA_CODIGO")]
    public string? CtaCodigo { get; set; }

    [Column("CFP_CODIGO")]
    public int? CfpCodigo { get; set; }

    [Column("CIN_NOMBRE")]
    public required string CinNombre { get; set; }

    [Column("CIN_NUMERO")]
    public int CinNumero { get; set; }

    [Column("CIN_CSTPRC")]
    public string? CinCstprc { get; set; }

    [Column("CIN_ESTADO")]
    public bool CinEstado { get; set; }
}
