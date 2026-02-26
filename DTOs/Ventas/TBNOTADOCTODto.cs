namespace ApiCm.DTOs.Ventas;

public sealed class TBNOTADOCTODTO
{
    public int NdmCompania { get; set; }
    public required string NdmModulo { get; set; }
    public int NdmCodigo { get; set; }
    public string? NdmNotaPie { get; set; }
    public string? NdmNota2 { get; set; }
    public required string NdmTipo { get; set; }
    public bool NdmDefecto { get; set; }
    public bool NdmEstado { get; set; }
}
