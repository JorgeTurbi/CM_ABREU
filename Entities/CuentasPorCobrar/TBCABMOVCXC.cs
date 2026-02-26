using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.CuentasPorCobrar;

[Table("TBCABMOVCXC")]
public class TBCABMOVCXC
{
    [Column("CMC_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CmcInternoNo { get; set; }

    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("TDC_TIPO")]
    public required string TdcTipo { get; set; }

    [Column("TDC_CODIGO")]
    public int TdcCodigo { get; set; }

    [Column("DXC_ANO")]
    public required string DxcAno { get; set; }

    [Column("CMC_NUMERO")]
    public int CmcNumero { get; set; }

    [Column("CTE_CODIGO")]
    public required string CteCodigo { get; set; }

    [Column("VEN_CODIGO")]
    public int VenCodigo { get; set; }

    [Column("CPG_CODIGO")]
    public int? CpgCodigo { get; set; }

    [Column("CMC_NCF")]
    public string? CmcNcf { get; set; }

    [Column("CMC_CONCEPTO")]
    public string? CmcConcepto { get; set; }

    [Column("CMC_DOCUMENTO")]
    public string? CmcDocumento { get; set; }

    [Column("CMC_FECHA")]
    public DateTime CmcFecha { get; set; }

    [Column("CMC_PROCESO")]
    public DateTime CmcProceso { get; set; }

    [Column("CMC_ELABORADO_POR")]
    public required string CmcElaboradoPor { get; set; }

    [Column("CMC_VALOR")]
    public decimal CmcValor { get; set; }

    [Column("CMC_IMPUESTO")]
    public decimal CmcImpuesto { get; set; }

    [Column("CMC_COMISION")]
    public decimal CmcComision { get; set; }

    [Column("CMC_TASA")]
    public decimal? CmcTasa { get; set; }

    [Column("CMC_IMPRESO")]
    public bool CmcImpreso { get; set; }

    [Column("CMC_EXPORTADO")]
    public bool CmcExportado { get; set; }

    [Column("CMC_CORREO")]
    public bool CmcCorreo { get; set; }

    [Column("CMC_POSTEADO")]
    public bool CmcPosteado { get; set; }

    [Column("CMC_NULO")]
    public bool CmcNulo { get; set; }

    [Column("CMC_ESTADO")]
    public bool CmcEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }

    [Column("CMC_ECF_NUMERO")]
    public string? CmcEcfNumero { get; set; }

    [Column("CMC_ECF_ESTADO")]
    public required string CmcEcfEstado { get; set; }

    [Column("CMC_TIPO_INGRESO")]
    public int CmcTipoIngreso { get; set; }

    [Column("CMC_FORMA_PAGO")]
    public int? CmcFormaPago { get; set; }
}
