using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBDESCTOCTEPRD")]
public class TBDESCTOCTEPRD
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("CTE_CODIGO")]
    public required string CteCodigo { get; set; }

    [Column("MON_CODIGO")]
    public int MonCodigo { get; set; }

    [Column("DSP_SECUENCIA")]
    public int DspSecuencia { get; set; }

    [Column("DSP_COMPANIA")]
    public int DspCompania { get; set; }

    [Column("PRD_CODIGO")]
    public required string PrdCodigo { get; set; }

    [Column("UNM_CODIGO")]
    public int UnmCodigo { get; set; }

    [Column("DSP_PRD_NOMBRE")]
    public string? DspPrdNombre { get; set; }

    [Column("DSP_TIPO")]
    public required string DspTipo { get; set; }

    [Column("DSP_VALOR")]
    public decimal DspValor { get; set; }

    [Column("DSP_SERVICIO")]
    public string? DspServicio { get; set; }

    [Column("DSP_ESTADO")]
    public bool DspEstado { get; set; }
}
