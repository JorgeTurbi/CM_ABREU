using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBDETTRFPRD")]
public class TBDETTRFPRD
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("CTP_NUMERO")]
    public int CtpNumero { get; set; }

    [Column("DTP_SECUENCIA")]
    public int DtpSecuencia { get; set; }

    [Column("DTP_COMPANIA")]
    public int DtpCompania { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DTP_OFI_DESTINO")]
    public int DtpOfiDestino { get; set; }

    [Column("DTP_ALM_ORIGEN")]
    public int DtpAlmOrigen { get; set; }

    [Column("DTP_ALM_DESTINO")]
    public int DtpAlmDestino { get; set; }

    [Column("DTP_FECHA")]
    public DateTime DtpFecha { get; set; }

    [Column("DTP_CANTIDAD")]
    public decimal DtpCantidad { get; set; }

    [Column("DTP_RECIBIDO")]
    public decimal DtpRecibido { get; set; }

    [Column("DTP_FACTOR")]
    public decimal DtpFactor { get; set; }

    [Column("DTP_PRECIO_UND")]
    public decimal DtpPrecioUnd { get; set; }

    [Column("DTP_COSTO_UND")]
    public decimal DtpCostoUnd { get; set; }

    [Column("DTP_IMPRESO")]
    public bool DtpImpreso { get; set; }

    [Column("DTP_POSTEADO")]
    public bool DtpPosteado { get; set; }

    [Column("DTP_ESTADO")]
    public bool DtpEstado { get; set; }

    [Column("DTP_SERIE")]
    public string? DtpSerie { get; set; }
}
