using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBPRODUCTO")]
public class TBPRODUCTO
{
    [Column("PRD_COMPANIA")]
    public int PrdCompania { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("CIA_CODIGO")]
    public int? CiaCodigo { get; set; }

    [Column("PRV_CODIGO")]
    public string? PrvCodigo { get; set; }

    [Column("PAI_CODIGO")]
    public int? PaiCodigo { get; set; }

    [Column("TIN_CODIGO")]
    public int TinCodigo { get; set; }

    [Column("DIV_CODIGO")]
    public int? DivCodigo { get; set; }

    [Column("CLA_CODIGO")]
    public int? ClaCodigo { get; set; }

    [Column("MAR_CODIGO")]
    public int? MarCodigo { get; set; }

    [Column("CCT_CODIGO")]
    public int? CctCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int? UnmCodigo { get; set; }

    [Column("PRD_CUENTA_INV")]
    public string? PrdCuentaInv { get; set; }

    [Column("PRD_CUENTA_CST")]
    public string? PrdCuentaCst { get; set; }

    [Column("PRD_CUENTA_ING")]
    public string? PrdCuentaIng { get; set; }

    [Column("PRD_CUENTA_DEV")]
    public string? PrdCuentaDev { get; set; }

    [Column("PRD_FOTO")]
    public byte[]? PrdFoto { get; set; }

    [Column("PRD_REFERENCIA")]
    public string? PrdReferencia { get; set; }

    [Column("PRD_CODIGO_ARANCEL")]
    public string? PrdCodigoArancel { get; set; }

    [Column("PRD_DESCR")]
    public required string PrdDescr { get; set; }

    [Column("PRD_DESCR_ORDEN")]
    public string? PrdDescrOrden { get; set; }

    [Column("PRD_DESCR_RESUMEN")]
    public string? PrdDescrResumen { get; set; }

    [Column("PRD_DESCR_ADICIONAL")]
    public string? PrdDescrAdicional { get; set; }

    [Column("PRD_DESCR_NOTA")]
    public string? PrdDescrNota { get; set; }

    [Column("PRD_SERIE_LOTE")]
    public required string PrdSerieLote { get; set; }

    [Column("PRD_COLOR")]
    public string? PrdColor { get; set; }

    [Column("PRD_DIM_VALOR")]
    public decimal? PrdDimValor { get; set; }

    [Column("PRD_DIM_NOMBRE")]
    public string? PrdDimNombre { get; set; }

    [Column("PRD_DIM_REDONDEO")]
    public bool PrdDimRedondeo { get; set; }

    [Column("PRD_PESO")]
    public decimal? PrdPeso { get; set; }

    [Column("PRD_PESO_NOMBRE")]
    public string? PrdPesoNombre { get; set; }

    [Column("PRD_EMPAQUE")]
    public decimal? PrdEmpaque { get; set; }

    [Column("PRD_FABRICANTE")]
    public string? PrdFabricante { get; set; }

    [Column("PRD_IMP_PORC")]
    public decimal PrdImpPorc { get; set; }

    [Column("PRD_IMP_INCL")]
    public bool PrdImpIncl { get; set; }

    [Column("PRD_COSTO_UCM")]
    public decimal PrdCostoUcm { get; set; }

    [Column("PRD_COSTO_PRM")]
    public decimal PrdCostoPrm { get; set; }

    [Column("PRD_COSTO_FJO")]
    public decimal PrdCostoFjo { get; set; }

    [Column("PRD_EXIST_USA")]
    public bool PrdExistUsa { get; set; }

    [Column("PRD_EXIST_MIN")]
    public decimal? PrdExistMin { get; set; }

    [Column("PRD_EXIST_MAX")]
    public decimal? PrdExistMax { get; set; }

    [Column("PRD_PUNTO_REORDEN")]
    public decimal? PrdPuntoReorden { get; set; }

    [Column("PRD_BGCOLOR")]
    public int? PrdBgcolor { get; set; }

    [Column("PRD_FGCOLOR")]
    public int? PrdFgcolor { get; set; }

    [Column("PRD_MODIFICADOR")]
    public required string PrdModificador { get; set; }

    [Column("PRD_COMISION")]
    public decimal PrdComision { get; set; }

    [Column("PRD_DESCUENTO_MAX")]
    public decimal PrdDescuentoMax { get; set; }

    [Column("PRD_USO_APLICACION")]
    public string? PrdUsoAplicacion { get; set; }

    [Column("PRD_GARAN_USA")]
    public bool PrdGaranUsa { get; set; }

    [Column("PRD_GARAN_VALOR")]
    public int? PrdGaranValor { get; set; }

    [Column("PRD_GARAN_DMA")]
    public string? PrdGaranDma { get; set; }

    [Column("PRD_INVENT_USA")]
    public bool PrdInventUsa { get; set; }

    [Column("PRD_USA_PRP")]
    public bool PrdUsaPrp { get; set; }

    [Column("PRD_USA_CMP")]
    public bool PrdUsaCmp { get; set; }

    [Column("PRD_USA_VEN")]
    public bool PrdUsaVen { get; set; }

    [Column("PRD_OFERTA")]
    public bool PrdOferta { get; set; }

    [Column("PRD_EXCLUSIVO")]
    public bool PrdExclusivo { get; set; }

    [Column("PRD_CONSIGNACION")]
    public bool PrdConsignacion { get; set; }

    [Column("PRD_ESTADO")]
    public bool PrdEstado { get; set; }

    [Column("PRD_TASA_UCM")]
    public decimal? PrdTasaUcm { get; set; }

    [Column("ISC_CODIGO")]
    public int? IscCodigo { get; set; }

    [Column("PRD_USA_CDT")]
    public bool PrdUsaCdt { get; set; }

    [Column("PRD_USA_ISC")]
    public bool PrdUsaIsc { get; set; }

    [Column("PRD_ISC_CANTIDAD")]
    public decimal? PrdIscCantidad { get; set; }

    [Column("PRD_ISC_UNDMED")]
    public int? PrdIscUndmed { get; set; }

    [Column("PRD_ISC_SUBCANTIDAD")]
    public decimal? PrdIscSubcantidad { get; set; }

    [Column("PRD_ISC_SUBUNDMED")]
    public int? PrdIscSubundmed { get; set; }

    [Column("PRD_ISC_GRADOS")]
    public decimal? PrdIscGrados { get; set; }

    [Column("PRD_ISC_PRECIO")]
    public decimal? PrdIscPrecio { get; set; }

    [Column("CPR_CODIGO")]
    public int? CprCodigo { get; set; }
}
