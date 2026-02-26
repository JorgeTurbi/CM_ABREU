using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBCPTVALLIQ")]
public class TBCPTVALLIQ
{
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

    [Column("CLQ_NUMERO")]
    public int ClqNumero { get; set; }

    [Column("CPL_CODIGO")]
    public int CplCodigo { get; set; }

    [Column("CVL_PASA_CXP")]
    public bool CvlPasaCxp { get; set; }

    [Column("CVL_VALOR")]
    public decimal CvlValor { get; set; }

    [Column("CVL_TASA")]
    public decimal? CvlTasa { get; set; }

    [Column("CVL_ESTADO")]
    public bool CvlEstado { get; set; }
}
