namespace ApiCm.DTOs.Inventario;

public sealed class TBDETTRFPRDDto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int CtpNumero { get; set; }
    public int DtpSecuencia { get; set; }
    public int DtpCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public int DtpOfiDestino { get; set; }
    public int DtpAlmOrigen { get; set; }
    public int DtpAlmDestino { get; set; }
    public DateTime DtpFecha { get; set; }
    public decimal DtpCantidad { get; set; }
    public decimal DtpRecibido { get; set; }
    public decimal DtpFactor { get; set; }
    public decimal DtpPrecioUnd { get; set; }
    public decimal DtpCostoUnd { get; set; }
    public bool DtpImpreso { get; set; }
    public bool DtpPosteado { get; set; }
    public bool DtpEstado { get; set; }
    public string? DtpSerie { get; set; }
}
