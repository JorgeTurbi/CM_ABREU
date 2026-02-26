namespace ApiCm.DTOs.Compras;

public sealed class TBLUGARENVCMPDto
{
    public int LepCompania { get; set; }
    public int LepCodigo { get; set; }
    public required string LepNombre { get; set; }
    public string? LepDireccion { get; set; }
    public string? LepTelefono { get; set; }
    public string? LepContacto { get; set; }
    public bool LepEstado { get; set; }
}
