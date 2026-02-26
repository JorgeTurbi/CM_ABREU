using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBCABTRFPRD")]
public class TBCABTRFPRD
{
    [Column("CTP_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CtpInternoNo { get; set; }

    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("CTP_NUMERO")]
    public int CtpNumero { get; set; }

    [Column("CTP_COMPANIA")]
    public int CtpCompania { get; set; }

    [Column("CTP_OFI_DESTINO")]
    public int CtpOfiDestino { get; set; }

    [Column("CTP_ALM_ORIGEN")]
    public int CtpAlmOrigen { get; set; }

    [Column("CTP_ALM_DESTINO")]
    public int CtpAlmDestino { get; set; }

    [Column("CTP_DOCUMENTO")]
    public string? CtpDocumento { get; set; }

    [Column("CTP_FECHA")]
    public DateTime CtpFecha { get; set; }

    [Column("CTP_PROCESO")]
    public DateTime CtpProceso { get; set; }

    [Column("CTP_CONCEPTO")]
    public string? CtpConcepto { get; set; }

    [Column("CTP_ELABORADO_POR")]
    public required string CtpElaboradoPor { get; set; }

    [Column("CTP_RECIBIDO_POR")]
    public string? CtpRecibidoPor { get; set; }

    [Column("CTP_RECIBIDO")]
    public DateTime? CtpRecibido { get; set; }

    [Column("CTP_TOTAL")]
    public decimal CtpTotal { get; set; }

    [Column("CTP_IMPRESO")]
    public bool CtpImpreso { get; set; }

    [Column("CTP_EXPORTADO")]
    public bool CtpExportado { get; set; }

    [Column("CTP_CORREO")]
    public bool CtpCorreo { get; set; }

    [Column("CTP_POSTEADO")]
    public bool CtpPosteado { get; set; }

    [Column("CTP_NULO")]
    public bool CtpNulo { get; set; }

    [Column("CTP_ESTADO")]
    public bool CtpEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }

    [Column("TRP_CODIGO")]
    public int? TrpCodigo { get; set; }
}
