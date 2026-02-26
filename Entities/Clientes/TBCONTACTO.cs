using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Clientes;

[Table("TBCONTACTO")]
public class TBCONTACTO
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("CON_CODIGO")]
    public int ConCodigo { get; set; }

    [Column("USR_CODIGO")]
    public string? UsrCodigo { get; set; }

    [Column("CON_NEGOCIO_PFISICA")]
    public required string ConNegocioPfisica { get; set; }

    [Column("CON_NOMBRE")]
    public required string ConNombre { get; set; }

    [Column("CON_CONTACTO")]
    public string? ConContacto { get; set; }

    [Column("CON_DIRECCION")]
    public string? ConDireccion { get; set; }

    [Column("CON_TELEFONO1")]
    public string? ConTelefono1 { get; set; }

    [Column("CON_TELEFONO2")]
    public string? ConTelefono2 { get; set; }

    [Column("CON_FAX")]
    public string? ConFax { get; set; }

    [Column("CON_CELULAR")]
    public string? ConCelular { get; set; }

    [Column("CON_BEEPER")]
    public string? ConBeeper { get; set; }

    [Column("CON_CENTRAL_BEEPER")]
    public string? ConCentralBeeper { get; set; }

    [Column("CON_RESIDENCIA")]
    public string? ConResidencia { get; set; }

    [Column("CON_FAMILIAR")]
    public string? ConFamiliar { get; set; }

    [Column("CON_E_MAIL")]
    public string? ConEMail { get; set; }

    [Column("CON_RNC_CEDULA")]
    public string? ConRncCedula { get; set; }

    [Column("CON_RELACION")]
    public string? ConRelacion { get; set; }

    [Column("CON_MEMO")]
    public string? ConMemo { get; set; }

    [Column("CON_ESTADO")]
    public bool ConEstado { get; set; }
}
