using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBPRDALM")]
public class TBPRDALM
{
    [Column("PAL_COMPANIA")]
    public int PalCompania { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("PAL_OFICINA")]
    public int PalOficina { get; set; }

    [Column("PAL_ALMACEN")]
    public int PalAlmacen { get; set; }

    [Column("PAL_UBICACION")]
    public string? PalUbicacion { get; set; }

    [Column("PAL_PEDIDO")]
    public decimal PalPedido { get; set; }

    [Column("PAL_CONDUCE")]
    public decimal PalConduce { get; set; }

    [Column("PAL_EXISTENCIA")]
    public decimal PalExistencia { get; set; }

    [Column("PAL_ESTADO")]
    public bool PalEstado { get; set; }

    [Column("PAL_LIQMER")]
    public decimal PalLiqmer { get; set; }
}
