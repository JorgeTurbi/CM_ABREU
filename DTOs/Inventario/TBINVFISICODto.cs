namespace ApiCm.DTOs.Inventario;

public sealed class TBINVFISICODto
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int AlmCodigo { get; set; }
    public int IfsCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int UnmCodigo { get; set; }
    public decimal IfsCantidad { get; set; }
    public decimal IfsFactor { get; set; }
    public DateTime IfsFecha { get; set; }
    public bool IfsEstado { get; set; }
}
