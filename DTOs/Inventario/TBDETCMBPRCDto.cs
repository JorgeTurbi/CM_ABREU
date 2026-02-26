namespace ApiCm.DTOs.Inventario;

public sealed class TBDETCMBPRCDto
{
    public int CiaCodigo { get; set; }
    public int CcpNumero { get; set; }
    public int DcpSecuencia { get; set; }
    public int DcpCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int CfpCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public DateTime DcpFecha { get; set; }
    public decimal DcpPrecioAnterior { get; set; }
    public decimal DcpPrecioNuevo { get; set; }
    public bool DcpImpreso { get; set; }
    public bool DcpPosteado { get; set; }
    public bool DcpEstado { get; set; }
}
