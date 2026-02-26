namespace ApiCm.DTOs.Inventario;

public sealed class TBPRODUCTODto
{
    public int PrdCompania { get; set; }
    public required string PrdCodigo { get; set; }
    public int? CiaCodigo { get; set; }
    public string? PrvCodigo { get; set; }
    public int? PaiCodigo { get; set; }
    public int TinCodigo { get; set; }
    public int? DivCodigo { get; set; }
    public int? ClaCodigo { get; set; }
    public int? MarCodigo { get; set; }
    public int? CctCodigo { get; set; }
    public int? UnmCodigo { get; set; }
    public string? PrdCuentaInv { get; set; }
    public string? PrdCuentaCst { get; set; }
    public string? PrdCuentaIng { get; set; }
    public string? PrdCuentaDev { get; set; }
    public byte[]? PrdFoto { get; set; }
    public string? PrdReferencia { get; set; }
    public string? PrdCodigoArancel { get; set; }
    public required string PrdDescr { get; set; }
    public string? PrdDescrOrden { get; set; }
    public string? PrdDescrResumen { get; set; }
    public string? PrdDescrAdicional { get; set; }
    public string? PrdDescrNota { get; set; }
    public required string PrdSerieLote { get; set; }
    public string? PrdColor { get; set; }
    public decimal? PrdDimValor { get; set; }
    public string? PrdDimNombre { get; set; }
    public bool PrdDimRedondeo { get; set; }
    public decimal? PrdPeso { get; set; }
    public string? PrdPesoNombre { get; set; }
    public decimal? PrdEmpaque { get; set; }
    public string? PrdFabricante { get; set; }
    public decimal PrdImpPorc { get; set; }
    public bool PrdImpIncl { get; set; }
    public decimal PrdCostoUcm { get; set; }
    public decimal PrdCostoPrm { get; set; }
    public decimal PrdCostoFjo { get; set; }
    public bool PrdExistUsa { get; set; }
    public decimal? PrdExistMin { get; set; }
    public decimal? PrdExistMax { get; set; }
    public decimal? PrdPuntoReorden { get; set; }
    public int? PrdBgcolor { get; set; }
    public int? PrdFgcolor { get; set; }
    public required string PrdModificador { get; set; }
    public decimal PrdComision { get; set; }
    public decimal PrdDescuentoMax { get; set; }
    public string? PrdUsoAplicacion { get; set; }
    public bool PrdGaranUsa { get; set; }
    public int? PrdGaranValor { get; set; }
    public string? PrdGaranDma { get; set; }
    public bool PrdInventUsa { get; set; }
    public bool PrdUsaPrp { get; set; }
    public bool PrdUsaCmp { get; set; }
    public bool PrdUsaVen { get; set; }
    public bool PrdOferta { get; set; }
    public bool PrdExclusivo { get; set; }
    public bool PrdConsignacion { get; set; }
    public bool PrdEstado { get; set; }
    public decimal? PrdTasaUcm { get; set; }
    public int? IscCodigo { get; set; }
    public bool PrdUsaCdt { get; set; }
    public bool PrdUsaIsc { get; set; }
    public decimal? PrdIscCantidad { get; set; }
    public int? PrdIscUndmed { get; set; }
    public decimal? PrdIscSubcantidad { get; set; }
    public int? PrdIscSubundmed { get; set; }
    public decimal? PrdIscGrados { get; set; }
    public decimal? PrdIscPrecio { get; set; }
    public int? CprCodigo { get; set; }
}
