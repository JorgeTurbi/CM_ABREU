namespace ApiCm.DTOs.Ventas;

public sealed class TBVENDEDORDTO
{
    public int CiaCodigo { get; set; }
    public int VenCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int? TrpCodigo { get; set; }
    public int VenCompania { get; set; }
    public required string VenNombre { get; set; }
    public string? VenTelefono1 { get; set; }
    public string? VenTelefono2 { get; set; }
    public required string VenTipo { get; set; }
    public decimal VenComisCob { get; set; }
    public decimal VenComisVen { get; set; }
    public bool VenSupervisor { get; set; }
    public string? VenCodigoEmp { get; set; }
    public bool VenEstado { get; set; }
    public int? VenCecVen { get; set; }
    public int? VenCecCob { get; set; }
}
