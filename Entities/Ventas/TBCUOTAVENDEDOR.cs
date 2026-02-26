using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCm.Entities.Ventas;

[Table("TBCUOTAVENDEDOR")]
public class TBCUOTAVENDEDOR
{
    [Column("CIA_CODIGO")]
    public int CiaCodigo { get; set; }

    [Column("VEN_CODIGO")]
    public int VenCodigo { get; set; }

    [Column("CVN_ANO")]
    public int CvnAno { get; set; }

    [Column("CVN_CUOTA_VENTA_01")]
    public decimal CvnCuotaVenta01 { get; set; }

    [Column("CVN_CUOTA_VENTA_02")]
    public decimal CvnCuotaVenta02 { get; set; }

    [Column("CVN_CUOTA_VENTA_03")]
    public decimal CvnCuotaVenta03 { get; set; }

    [Column("CVN_CUOTA_VENTA_04")]
    public decimal CvnCuotaVenta04 { get; set; }

    [Column("CVN_CUOTA_VENTA_05")]
    public decimal CvnCuotaVenta05 { get; set; }

    [Column("CVN_CUOTA_VENTA_06")]
    public decimal CvnCuotaVenta06 { get; set; }

    [Column("CVN_CUOTA_VENTA_07")]
    public decimal CvnCuotaVenta07 { get; set; }

    [Column("CVN_CUOTA_VENTA_08")]
    public decimal CvnCuotaVenta08 { get; set; }

    [Column("CVN_CUOTA_VENTA_09")]
    public decimal CvnCuotaVenta09 { get; set; }

    [Column("CVN_CUOTA_VENTA_10")]
    public decimal CvnCuotaVenta10 { get; set; }

    [Column("CVN_CUOTA_VENTA_11")]
    public decimal CvnCuotaVenta11 { get; set; }

    [Column("CVN_CUOTA_VENTA_12")]
    public decimal CvnCuotaVenta12 { get; set; }

    [Column("CVN_CUOTA_COBRO_01")]
    public decimal CvnCuotaCobro01 { get; set; }

    [Column("CVN_CUOTA_COBRO_02")]
    public decimal CvnCuotaCobro02 { get; set; }

    [Column("CVN_CUOTA_COBRO_03")]
    public decimal CvnCuotaCobro03 { get; set; }

    [Column("CVN_CUOTA_COBRO_04")]
    public decimal CvnCuotaCobro04 { get; set; }

    [Column("CVN_CUOTA_COBRO_05")]
    public decimal CvnCuotaCobro05 { get; set; }

    [Column("CVN_CUOTA_COBRO_06")]
    public decimal CvnCuotaCobro06 { get; set; }

    [Column("CVN_CUOTA_COBRO_07")]
    public decimal CvnCuotaCobro07 { get; set; }

    [Column("CVN_CUOTA_COBRO_08")]
    public decimal CvnCuotaCobro08 { get; set; }

    [Column("CVN_CUOTA_COBRO_09")]
    public decimal CvnCuotaCobro09 { get; set; }

    [Column("CVN_CUOTA_COBRO_10")]
    public decimal CvnCuotaCobro10 { get; set; }

    [Column("CVN_CUOTA_COBRO_11")]
    public decimal CvnCuotaCobro11 { get; set; }

    [Column("CVN_CUOTA_COBRO_12")]
    public decimal CvnCuotaCobro12 { get; set; }

    [Column("CVN_ESTADO")]
    public bool CvnEstado { get; set; }
}
