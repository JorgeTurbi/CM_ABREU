using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBCABCMBPRC")]
public class TBCABCMBPRC
{
    [Column("CCP_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CcpInternoNo { get; set; }

    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("CCP_NUMERO")]
    public int CcpNumero { get; set; }

    [Column("CCP_COMPANIA")]
    public int CcpCompania { get; set; }

    [Column("CCP_DOCUMENTO")]
    public string? CcpDocumento { get; set; }

    [Column("CCP_FECHA")]
    public DateTime CcpFecha { get; set; }

    [Column("CCP_CONCEPTO")]
    public string? CcpConcepto { get; set; }

    [Column("CCP_ELABORADO_POR")]
    public required string CcpElaboradoPor { get; set; }

    [Column("CCP_PROCESO")]
    public DateTime CcpProceso { get; set; }

    [Column("CCP_IMPRESO")]
    public bool CcpImpreso { get; set; }

    [Column("CCP_EXPORTADO")]
    public bool CcpExportado { get; set; }

    [Column("CCP_CORREO")]
    public bool CcpCorreo { get; set; }

    [Column("CCP_POSTEADO")]
    public bool CcpPosteado { get; set; }

    [Column("CCP_NULO")]
    public bool CcpNulo { get; set; }

    [Column("CCP_ESTADO")]
    public bool CcpEstado { get; set; }
}
