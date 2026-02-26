using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBALMACEN")]
public class TBALMACEN
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("ALM_CODIGO")]
    public int AlmCodigo { get; set; }

    [Column("ALM_NOMBRE")]
    public required string AlmNombre { get; set; }

    [Column("ALM_DIRECCION")]
    public string? AlmDireccion { get; set; }

    [Column("ALM_TELEFONO1")]
    public string? AlmTelefono1 { get; set; }

    [Column("ALM_TELEFONO2")]
    public string? AlmTelefono2 { get; set; }

    [Column("ALM_FAX")]
    public string? AlmFax { get; set; }

    [Column("ALM_ENCARGADO")]
    public string? AlmEncargado { get; set; }

    [Column("ALM_TIPO")]
    public required string AlmTipo { get; set; }

    [Column("ALM_USA_COMPRA")]
    public bool AlmUsaCompra { get; set; }

    [Column("ALM_USA_FACTURA")]
    public bool AlmUsaFactura { get; set; }

    [Column("ALM_ESTADO")]
    public bool AlmEstado { get; set; }
}
