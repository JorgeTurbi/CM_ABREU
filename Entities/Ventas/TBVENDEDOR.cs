using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBVENDEDOR")]
public class TBVENDEDOR
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("VEN_CODIGO")]
    public int VenCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("TRP_CODIGO")]
    public int? TrpCodigo { get; set; }

    [Column("VEN_COMPANIA")]
    public int VenCompania { get; set; }

    [Column("VEN_NOMBRE")]
    public required string VenNombre { get; set; }

    [Column("VEN_TELEFONO1")]
    public string? VenTelefono1 { get; set; }

    [Column("VEN_TELEFONO2")]
    public string? VenTelefono2 { get; set; }

    [Column("VEN_TIPO")]
    public required string VenTipo { get; set; }

    [Column("VEN_COMIS_COB")]
    public decimal VenComisCob { get; set; }

    [Column("VEN_COMIS_VEN")]
    public decimal VenComisVen { get; set; }

    [Column("VEN_SUPERVISOR")]
    public bool VenSupervisor { get; set; }

    [Column("VEN_CODIGO_EMP")]
    public string? VenCodigoEmp { get; set; }

    [Column("VEN_ESTADO")]
    public bool VenEstado { get; set; }

    [Column("VEN_CEC_VEN")]
    public int? VenCecVen { get; set; }

    [Column("VEN_CEC_COB")]
    public int? VenCecCob { get; set; }
}
