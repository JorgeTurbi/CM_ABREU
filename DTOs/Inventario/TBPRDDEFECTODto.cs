namespace ApiCm.DTOs.Inventario;

public sealed class TBPRDDEFECTODto
{
    public int PddCompania { get; set; }
    public int? MarCodigo { get; set; }
    public int? PaiCodigo { get; set; }
    public int? TinCodigo { get; set; }
    public int? ClaCodigo { get; set; }
    public bool PddExistUsa { get; set; }
    public int? UnmCodigo { get; set; }
    public int? CfpCodigo { get; set; }
    public int? DivCodigo { get; set; }
    public string? PddDimNombre { get; set; }
    public string? PddPesoNombre { get; set; }
    public decimal? PddImpPorc { get; set; }
    public decimal? PddExistMin { get; set; }
    public decimal? PddExistMax { get; set; }
    public decimal? PddPuntoReorden { get; set; }
    public decimal? PddComision { get; set; }
    public decimal? PddDescuentoMax { get; set; }
    public bool PddInventUsa { get; set; }
    public bool PddExclusivo { get; set; }
    public bool PddConsignacion { get; set; }
}
