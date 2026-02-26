namespace ApiCm.DTOs.Clientes;

public sealed class TBCIUDADDto
{
    public int CdaCodigo { get; set; }
    public required string CdaNombre { get; set; }
    public bool CdaEstado { get; set; }
}
