using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBDETENTSAL")]
public class TBDETENTSAL
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("CIN_TIPO")]
    public required string CinTipo { get; set; }

    [Column("CIN_CODIGO")]
    public int CinCodigo { get; set; }

    [Column("CES_NUMERO")]
    public int CesNumero { get; set; }

    [Column("DES_SECUENCIA")]
    public int DesSecuencia { get; set; }

    [Column("DES_COMPANIA")]
    public int DesCompania { get; set; }

    [Column("ALM_CODIGO")]
    public int AlmCodigo { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DES_FECHA")]
    public DateTime DesFecha { get; set; }

    [Column("DES_CANTIDAD")]
    public decimal DesCantidad { get; set; }

    [Column("DES_FACTOR")]
    public decimal DesFactor { get; set; }

    [Column("DES_COSTO_UND")]
    public decimal DesCostoUnd { get; set; }

    [Column("DES_PRECIO_UND")]
    public decimal DesPrecioUnd { get; set; }

    [Column("DES_IMPRESO")]
    public bool DesImpreso { get; set; }

    [Column("DES_POSTEADO")]
    public bool DesPosteado { get; set; }

    [Column("DES_ESTADO")]
    public bool DesEstado { get; set; }

    [Column("DES_SERIE")]
    public string? DesSerie { get; set; }
}
