namespace ApiCm.DTOs.Ventas;

public sealed class TBREPARTDTO
{
    public int RepCompania { get; set; }
    public int RepCodigo { get; set; }
    public required string RepNombre { get; set; }
    public string? RepTelefono1 { get; set; }
    public string? RepTelefono2 { get; set; }
    public bool RepEstado { get; set; }
}
