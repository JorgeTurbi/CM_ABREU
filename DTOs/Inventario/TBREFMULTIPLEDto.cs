namespace ApiCm.DTOs.Inventario;

public sealed class TBREFMULTIPLEDto
{
    public int PrdCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int RefSecuencia { get; set; }
    public required string RefReferencia { get; set; }
    public bool RefEstado { get; set; }
}
