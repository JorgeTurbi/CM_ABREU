using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBCABINVFIS")]
public class TBCABINVFIS
{
    [Column("CIF_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CifInternoNo { get; set; }

    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("CIF_NUMERO")]
    public int CifNumero { get; set; }

    [Column("CIF_COMPANIA")]
    public int CifCompania { get; set; }

    [Column("ALM_CODIGO")]
    public int AlmCodigo { get; set; }

    [Column("CIF_DOCUMENTO")]
    public string? CifDocumento { get; set; }

    [Column("CIF_FECHA")]
    public DateTime CifFecha { get; set; }

    [Column("CIF_CONCEPTO")]
    public string? CifConcepto { get; set; }

    [Column("CIF_ELABORADO_POR")]
    public required string CifElaboradoPor { get; set; }

    [Column("CIF_PROCESO")]
    public DateTime CifProceso { get; set; }

    [Column("CIF_IMPRESO")]
    public bool CifImpreso { get; set; }

    [Column("CIF_EXPORTADO")]
    public bool CifExportado { get; set; }

    [Column("CIF_CORREO")]
    public bool CifCorreo { get; set; }

    [Column("CIF_POSTEADO")]
    public bool CifPosteado { get; set; }

    [Column("CIF_NULO")]
    public bool CifNulo { get; set; }

    [Column("CIF_ESTADO")]
    public bool CifEstado { get; set; }

    [Column("CIF_ENT_TIPO")]
    public string? CifEntTipo { get; set; }

    [Column("CIF_ENT_CODIGO")]
    public int? CifEntCodigo { get; set; }

    [Column("CIF_ENT_NUMERO")]
    public int? CifEntNumero { get; set; }

    [Column("CIF_SAL_TIPO")]
    public string? CifSalTipo { get; set; }

    [Column("CIF_SAL_CODIGO")]
    public int? CifSalCodigo { get; set; }

    [Column("CIF_SAL_NUMERO")]
    public int? CifSalNumero { get; set; }
}
