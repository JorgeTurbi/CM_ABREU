namespace ApiCm.DTOs.Inventario;

public sealed class TBPRDALMDto
{
    public int PalCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int PalOficina { get; set; }
    public int PalAlmacen { get; set; }
    public string? PalUbicacion { get; set; }
    public decimal PalPedido { get; set; }
    public decimal PalConduce { get; set; }
    public decimal PalExistencia { get; set; }
    public bool PalEstado { get; set; }
    public decimal PalLiqmer { get; set; }
}
