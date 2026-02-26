namespace ApiCm.DTOs.Ventas;

public sealed class TBVALDNMCUADREDTO
{
    public int CiaCodigo { get; set; }
    public required string CajCodigo { get; set; }
    public int MonCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public DateTime CjcFecha { get; set; }
    public int DnmCodigo { get; set; }
    public decimal CjdValor { get; set; }
    public bool CjdEstado { get; set; }
}
