using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBPRDDEFECTO")]
public class TBPRDDEFECTO
{
    [Column("PDD_COMPANIA")]
    public int PddCompania { get; set; }

    [Column("MAR_CODIGO")]
    public int? MarCodigo { get; set; }

    [Column("PAI_CODIGO")]
    public int? PaiCodigo { get; set; }

    [Column("TIN_CODIGO")]
    public int? TinCodigo { get; set; }

    [Column("CLA_CODIGO")]
    public int? ClaCodigo { get; set; }

    [Column("PDD_EXIST_USA")]
    public bool PddExistUsa { get; set; }

    [Column("UNM_CODIGO")]
    public int? UnmCodigo { get; set; }

    [Column("CFP_CODIGO")]
    public int? CfpCodigo { get; set; }

    [Column("DIV_CODIGO")]
    public int? DivCodigo { get; set; }

    [Column("PDD_DIM_NOMBRE")]
    public string? PddDimNombre { get; set; }

    [Column("PDD_PESO_NOMBRE")]
    public string? PddPesoNombre { get; set; }

    [Column("PDD_IMP_PORC")]
    public decimal? PddImpPorc { get; set; }

    [Column("PDD_EXIST_MIN")]
    public decimal? PddExistMin { get; set; }

    [Column("PDD_EXIST_MAX")]
    public decimal? PddExistMax { get; set; }

    [Column("PDD_PUNTO_REORDEN")]
    public decimal? PddPuntoReorden { get; set; }

    [Column("PDD_COMISION")]
    public decimal? PddComision { get; set; }

    [Column("PDD_DESCUENTO_MAX")]
    public decimal? PddDescuentoMax { get; set; }

    [Column("PDD_INVENT_USA")]
    public bool PddInventUsa { get; set; }

    [Column("PDD_EXCLUSIVO")]
    public bool PddExclusivo { get; set; }

    [Column("PDD_CONSIGNACION")]
    public bool PddConsignacion { get; set; }
}
