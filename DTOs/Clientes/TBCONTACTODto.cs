namespace ApiCm.DTOs.Clientes;

public sealed class TBCONTACTODto
{
    public int CiaCodigo { get; set; }
    public int ConCodigo { get; set; }
    public string? UsrCodigo { get; set; }
    public required string ConNegocioPfisica { get; set; }
    public required string ConNombre { get; set; }
    public string? ConContacto { get; set; }
    public string? ConDireccion { get; set; }
    public string? ConTelefono1 { get; set; }
    public string? ConTelefono2 { get; set; }
    public string? ConFax { get; set; }
    public string? ConCelular { get; set; }
    public string? ConBeeper { get; set; }
    public string? ConCentralBeeper { get; set; }
    public string? ConResidencia { get; set; }
    public string? ConFamiliar { get; set; }
    public string? ConEMail { get; set; }
    public string? ConRncCedula { get; set; }
    public string? ConRelacion { get; set; }
    public string? ConMemo { get; set; }
    public bool ConEstado { get; set; }
}
