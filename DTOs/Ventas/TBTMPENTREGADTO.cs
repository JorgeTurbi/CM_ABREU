namespace ApiCm.DTOs.Ventas;

public sealed class TBTMPENTREGADTO
{
    public int TenCompania { get; set; }
    public int TenCodigo { get; set; }
    public required string TenNombre { get; set; }
    public bool TenEstado { get; set; }
}
