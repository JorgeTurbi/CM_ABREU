using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Compras;

[Table("TBDOCTOCMP")]
public class TBDOCTOCMP
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

    [Column("DCM_COMPANIA")]
    public int DcmCompania { get; set; }

    [Column("NDM_MODULO")]
    public required string NdmModulo { get; set; }

    [Column("NDM_CODIGO")]
    public int? NdmCodigo { get; set; }

    [Column("DCM_NUMERO")]
    public int DcmNumero { get; set; }

    [Column("DCM_FORMATO_IMP")]
    public string? DcmFormatoImp { get; set; }

    [Column("DCM_ESTADO")]
    public bool DcmEstado { get; set; }
}
