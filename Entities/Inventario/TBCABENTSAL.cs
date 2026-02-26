using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBCABENTSAL")]
public class TBCABENTSAL
{
    [Column("CES_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CesInternoNo { get; set; }

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

    [Column("DPN_CODIGO")]
    public int? DpnCodigo { get; set; }

    [Column("CES_COMPANIA")]
    public int CesCompania { get; set; }

    [Column("CES_DOCUMENTO")]
    public string? CesDocumento { get; set; }

    [Column("CES_FECHA")]
    public DateTime CesFecha { get; set; }

    [Column("CES_PROCESO")]
    public DateTime CesProceso { get; set; }

    [Column("CES_CONCEPTO")]
    public string? CesConcepto { get; set; }

    [Column("CES_TOTAL")]
    public decimal CesTotal { get; set; }

    [Column("CES_ELABORADO_POR")]
    public required string CesElaboradoPor { get; set; }

    [Column("CES_IMPRESO")]
    public bool CesImpreso { get; set; }

    [Column("CES_EXPORTADO")]
    public bool CesExportado { get; set; }

    [Column("CES_CORREO")]
    public bool CesCorreo { get; set; }

    [Column("CES_POSTEADO")]
    public bool CesPosteado { get; set; }

    [Column("CES_NULO")]
    public bool CesNulo { get; set; }

    [Column("CES_ESTADO")]
    public bool CesEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }
}
