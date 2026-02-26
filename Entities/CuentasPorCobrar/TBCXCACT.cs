using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.CuentasPorCobrar;

[Table("TBCXCACT")]
public class TBCXCACT
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("CCA_MODULO")]
    public required string CcaModulo { get; set; }

    [Column("CCA_TIPO")]
    public required string CcaTipo { get; set; }

    [Column("CCA_CODIGO")]
    public int CcaCodigo { get; set; }

    [Column("CCA_ANO")]
    public required string CcaAno { get; set; }

    [Column("CCA_NUMERO")]
    public int CcaNumero { get; set; }

    [Column("CCA_SECUENCIA")]
    public int CcaSecuencia { get; set; }

    [Column("CCA_SUBSEC")]
    public int CcaSubsec { get; set; }

    [Column("CTE_CODIGO")]
    public required string CteCodigo { get; set; }

    [Column("VEN_CODIGO")]
    public int VenCodigo { get; set; }

    [Column("CCA_OFICINA")]
    public int CcaOficina { get; set; }

    [Column("CCA_COBRADOR")]
    public int CcaCobrador { get; set; }

    [Column("CCA_REF_TIPO")]
    public required string CcaRefTipo { get; set; }

    [Column("CCA_REF_NUMERO")]
    public required string CcaRefNumero { get; set; }

    [Column("CCA_ORDEN")]
    public required string CcaOrden { get; set; }

    [Column("CCA_NCF")]
    public string? CcaNcf { get; set; }

    [Column("CCA_DOCTO_MANUAL")]
    public string? CcaDoctoManual { get; set; }

    [Column("CCA_FECHA")]
    public DateTime CcaFecha { get; set; }

    [Column("CCA_FECHA_VENCE")]
    public DateTime? CcaFechaVence { get; set; }

    [Column("CCA_DIA_EFECTIVIDAD")]
    public int? CcaDiaEfectividad { get; set; }

    [Column("CCA_VALOR")]
    public decimal CcaValor { get; set; }

    [Column("CCA_IMPUESTO")]
    public decimal CcaImpuesto { get; set; }

    [Column("CCA_EFECTO")]
    public int CcaEfecto { get; set; }

    [Column("CCA_TASA")]
    public decimal? CcaTasa { get; set; }

    [Column("CCA_RECIBO_CHK_DEV")]
    public bool CcaReciboChkDev { get; set; }

    [Column("CCA_ESTADO")]
    public bool CcaEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }

    [Column("CCA_FACTURA")]
    public int CcaFactura { get; set; }
}
