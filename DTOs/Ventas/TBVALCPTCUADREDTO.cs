namespace ApiCm.DTOs.Ventas;

public sealed class TBVALCPTCUADREDTO
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public required string CajCodigo { get; set; }
    public int MonCodigo { get; set; }
    public DateTime CjcFecha { get; set; }
    public int CjcCodigo { get; set; }
    public decimal CjtValor { get; set; }
    public bool CjtEstado { get; set; }
}
