using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBCABSOLCOT")]
public class TBCABSOLCOT
{
    [Column("CST_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CstInternoNo { get; set; }

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

    [Column("CST_NUMERO")]
    public int CstNumero { get; set; }

    [Column("CST_COMPANIA")]
    public int CstCompania { get; set; }

    [Column("CST_FECHA")]
    public DateTime CstFecha { get; set; }

    [Column("CST_PROCESO")]
    public DateTime CstProceso { get; set; }

    [Column("CST_PRV_CODIGO")]
    public string? CstPrvCodigo { get; set; }

    [Column("CST_PRV_NOMBRE")]
    public string? CstPrvNombre { get; set; }

    [Column("CST_NOTA_PIE")]
    public string? CstNotaPie { get; set; }

    [Column("CST_ELABORADO_POR")]
    public required string CstElaboradoPor { get; set; }

    [Column("CST_GENERADO")]
    public required string CstGenerado { get; set; }

    [Column("CST_IMPRESO")]
    public bool CstImpreso { get; set; }

    [Column("CST_EXPORTADO")]
    public bool CstExportado { get; set; }

    [Column("CST_CORREO")]
    public bool CstCorreo { get; set; }

    [Column("CST_POSTEADO")]
    public bool CstPosteado { get; set; }

    [Column("CST_NULO")]
    public bool CstNulo { get; set; }

    [Column("CST_ESTADO")]
    public bool CstEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }
}
