using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.CuentasPorCobrar;

[Table("TBCABRECIBO")]
public class TBCABRECIBO
{
    [Column("CRC_INTERNO_NO")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CrcInternoNo { get; set; }

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

    [Column("CRC_NUMERO")]
    public int CrcNumero { get; set; }

    [Column("CTE_CODIGO")]
    public string? CteCodigo { get; set; }

    [Column("CRC_COB_CODIGO")]
    public int CrcCobCodigo { get; set; }

    [Column("CAJ_CODIGO")]
    public required string CajCodigo { get; set; }

    [Column("BCC_CODIGO")]
    public int? BccCodigo { get; set; }

    [Column("TAR_CODIGO")]
    public int? TarCodigo { get; set; }

    [Column("CRC_CHEQUE_DEV")]
    public bool CrcChequeDev { get; set; }

    [Column("CRC_TIPO_CRN")]
    public required string CrcTipoCrn { get; set; }

    [Column("CRC_CONCEPTO")]
    public string? CrcConcepto { get; set; }

    [Column("CRC_FECHA")]
    public DateTime CrcFecha { get; set; }

    [Column("CRC_PROCESO")]
    public DateTime CrcProceso { get; set; }

    [Column("CRC_ELABORADO_POR")]
    public required string CrcElaboradoPor { get; set; }

    [Column("CRC_DOCUMENTO")]
    public string? CrcDocumento { get; set; }

    [Column("CRC_NOMBRE")]
    public string? CrcNombre { get; set; }

    [Column("CRC_VALOR")]
    public decimal CrcValor { get; set; }

    [Column("CRC_COMISION")]
    public decimal CrcComision { get; set; }

    [Column("CRC_TASA")]
    public decimal? CrcTasa { get; set; }

    [Column("CRC_DPGO_BCO")]
    public string? CrcDpgoBco { get; set; }

    [Column("CRC_DPGO_TPO")]
    public string? CrcDpgoTpo { get; set; }

    [Column("CRC_DPGO_ANM")]
    public string? CrcDpgoAnm { get; set; }

    [Column("CRC_DPGO_NUM")]
    public int? CrcDpgoNum { get; set; }

    [Column("CRC_CHQ_VALOR")]
    public decimal CrcChqValor { get; set; }

    [Column("CRC_CHQ_NUMERO")]
    public string? CrcChqNumero { get; set; }

    [Column("CRC_CHQ_CUENTA")]
    public string? CrcChqCuenta { get; set; }

    [Column("CRC_EFE_VALOR")]
    public decimal CrcEfeValor { get; set; }

    [Column("CRC_DPT_VALOR")]
    public decimal CrcDptValor { get; set; }

    [Column("CRC_DPT_NUMERO")]
    public string? CrcDptNumero { get; set; }

    [Column("CRC_CPN_VALOR")]
    public decimal CrcCpnValor { get; set; }

    [Column("CRC_NCR_VALOR")]
    public decimal CrcNcrValor { get; set; }

    [Column("CRC_TRJ_VALOR")]
    public decimal CrcTrjValor { get; set; }

    [Column("CRC_TRJ_APROB")]
    public string? CrcTrjAprob { get; set; }

    [Column("CRC_PRM_VALOR")]
    public decimal CrcPrmValor { get; set; }

    [Column("CRC_CHQ_DIA_EFECT")]
    public int? CrcChqDiaEfect { get; set; }

    [Column("CRC_IMPRESO")]
    public bool CrcImpreso { get; set; }

    [Column("CRC_EXPORTADO")]
    public bool CrcExportado { get; set; }

    [Column("CRC_CORREO")]
    public bool CrcCorreo { get; set; }

    [Column("CRC_POSTEADO")]
    public bool CrcPosteado { get; set; }

    [Column("CRC_NULO")]
    public bool CrcNulo { get; set; }

    [Column("CRC_ESTADO")]
    public bool CrcEstado { get; set; }

    [Column("PRY_CODIGO")]
    public string? PryCodigo { get; set; }

    [Column("CRC_TRJ_NUMERO")]
    public string? CrcTrjNumero { get; set; }
}
