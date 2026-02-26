using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBCABREQCMP")]
public class TBCABREQCMP
{
    [Column("CRP_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CrpInternoNo { get; set; }

    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("TDM_TIPO")]
    public required string TdmTipo { get; set; }

    [Column("TDM_CODIGO")]
    public int TdmCodigo { get; set; }

    [Column("DCM_ANO")]
    public required string DcmAno { get; set; }

    [Column("CRP_NUMERO")]
    public int CrpNumero { get; set; }

    [Column("CRP_COMPANIA")]
    public int CrpCompania { get; set; }

    [Column("DPN_CODIGO")]
    public int? DpnCodigo { get; set; }

    [Column("CRP_FECHA")]
    public DateTime CrpFecha { get; set; }

    [Column("CRP_PROCESO")]
    public DateTime CrpProceso { get; set; }

    [Column("CRP_PRV_CODIGO")]
    public string? CrpPrvCodigo { get; set; }

    [Column("CRP_PRV_NOMBRE")]
    public string? CrpPrvNombre { get; set; }

    [Column("CRP_NOTA_PIE")]
    public string? CrpNotaPie { get; set; }

    [Column("CRP_ELABORADO_POR")]
    public required string CrpElaboradoPor { get; set; }

    [Column("CRP_GENERADO")]
    public required string CrpGenerado { get; set; }

    [Column("CRP_IMPRESO")]
    public bool CrpImpreso { get; set; }

    [Column("CRP_EXPORTADO")]
    public bool CrpExportado { get; set; }

    [Column("CRP_CORREO")]
    public bool CrpCorreo { get; set; }

    [Column("CRP_POSTEADO")]
    public bool CrpPosteado { get; set; }

    [Column("CRP_NULO")]
    public bool CrpNulo { get; set; }

    [Column("CRP_ESTADO")]
    public bool CrpEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }
}
