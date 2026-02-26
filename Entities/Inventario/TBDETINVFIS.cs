using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Inventario;

[Table("TBDETINVFIS")]
public class TBDETINVFIS
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("OFI_CODIGO")]
    public int OfiCodigo { get; set; }

    [Column("CIF_NUMERO")]
    public int CifNumero { get; set; }

    [Column("DIF_SECUENCIA")]
    public int DifSecuencia { get; set; }

    [Column("DIF_COMPANIA")]
    public int DifCompania { get; set; }

    [Column("DIF_UBICACION")]
    public string? DifUbicacion { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DIF_FECHA")]
    public DateTime DifFecha { get; set; }

    [Column("DIF_CANT_FISICA")]
    public decimal DifCantFisica { get; set; }

    [Column("DIF_CANT_PERPETUA")]
    public decimal DifCantPerpetua { get; set; }

    [Column("DIF_COSTO_UND")]
    public decimal DifCostoUnd { get; set; }

    [Column("DIF_IMPRESO")]
    public bool DifImpreso { get; set; }

    [Column("DIF_POSTEADO")]
    public bool DifPosteado { get; set; }

    [Column("DIF_ESTADO")]
    public bool DifEstado { get; set; }

    [Column("DIF_SERIE")]
    public string? DifSerie { get; set; }
}
