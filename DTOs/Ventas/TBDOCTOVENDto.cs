namespace ApiCm.DTOs.Ventas;

public sealed class TBDOCTOVENDTO
{
    public int CiaCodigo { get; set; }
    public int OfiCodigo { get; set; }
    public int MonCodigo { get; set; }
    public required string TdvTipo { get; set; }
    public int TdvCodigo { get; set; }
    public required string DnvAno { get; set; }
    public int DnvCompania { get; set; }
    public required string NdmModulo { get; set; }
    public int? NdmCodigo { get; set; }
    public int? TncCodigo { get; set; }
    public int DnvNumero { get; set; }
    public bool DnvUsaPrp { get; set; }
    public string? DnvFormatoImp { get; set; }
    public bool DnvEstado { get; set; }
}
