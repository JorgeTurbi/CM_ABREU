using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.CuentasPorCobrar;

[Table("TBCXCHIS")]
public class TBCXCHIS
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("CCH_MODULO")]
    public required string CchModulo { get; set; }

    [Column("CCH_TIPO")]
    public required string CchTipo { get; set; }

    [Column("CCH_CODIGO")]
    public int CchCodigo { get; set; }

    [Column("CCH_ANO")]
    public required string CchAno { get; set; }

    [Column("CCH_NUMERO")]
    public int CchNumero { get; set; }

    [Column("CCH_SECUENCIA")]
    public int CchSecuencia { get; set; }

    [Column("CCH_SUBSEC")]
    public int CchSubsec { get; set; }

    [Column("CTE_CODIGO")]
    public required string CteCodigo { get; set; }

    [Column("VEN_CODIGO")]
    public int VenCodigo { get; set; }

    [Column("CCH_OFICINA")]
    public int CchOficina { get; set; }

    [Column("CCH_COBRADOR")]
    public int CchCobrador { get; set; }

    [Column("CCH_REF_TIPO")]
    public required string CchRefTipo { get; set; }

    [Column("CCH_REF_NUMERO")]
    public required string CchRefNumero { get; set; }

    [Column("CCH_ORDEN")]
    public required string CchOrden { get; set; }

    [Column("CCH_NCF")]
    public string? CchNcf { get; set; }

    [Column("CCH_DOCTO_MANUAL")]
    public string? CchDoctoManual { get; set; }

    [Column("CCH_FECHA")]
    public DateTime CchFecha { get; set; }

    [Column("CCH_FECHA_VENCE")]
    public DateTime? CchFechaVence { get; set; }

    [Column("CCH_DIA_EFECTIVIDAD")]
    public int? CchDiaEfectividad { get; set; }

    [Column("CCH_VALOR")]
    public decimal CchValor { get; set; }

    [Column("CCH_IMPUESTO")]
    public decimal CchImpuesto { get; set; }

    [Column("CCH_EFECTO")]
    public int CchEfecto { get; set; }

    [Column("CCH_TASA")]
    public decimal? CchTasa { get; set; }

    [Column("CCH_RECIBO_CHK_DEV")]
    public bool CchReciboChkDev { get; set; }

    [Column("CCH_ESTADO")]
    public bool CchEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }

    [Column("CCH_FACTURA")]
    public int CchFactura { get; set; }
}
