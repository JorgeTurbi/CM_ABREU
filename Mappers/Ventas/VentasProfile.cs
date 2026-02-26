using ApiCm.DTOs.Ventas;
using ApiCm.Entities.Ventas;
using AutoMapper;

namespace ApiCm.Mappers.Ventas;

public class VentasProfile : Profile
{
    public VentasProfile()
    {
        // ===== VENDEDOR =====
        CreateMap<TBVENDEDOR, TBVENDEDORDTO>().ReverseMap();

        // ===== ZONA =====
        CreateMap<TBZONA, TBZONADTO>().ReverseMap();

        // ===== RUTA =====
        CreateMap<TBRUTA, TBRUTADTO>().ReverseMap();

        // ===== CUOTA VENDEDOR =====
        CreateMap<TBCUOTAVENDEDOR, TBCUOTAVENDEDORDTO>().ReverseMap();

        // ===== LUGAR ENVIO CLIENTE =====
        CreateMap<TBLUGARENVIOCTL, TBLUGARENVIOCTEDto>().ReverseMap();

        // ===== REPARTO =====
        CreateMap<TBREPART, TBREPARTDTO>().ReverseMap();

        // ===== DESCUENTO CLIENTE PRODUCTO =====
        CreateMap<TBDESCTOCTEPRD, TBDESCTOCTEPRDDTO>().ReverseMap();

        // ===== TIEMPO ENTREGA =====
        CreateMap<TBTMPENTREGA, TBTMPENTREGADTO>().ReverseMap();

        // ===== NOTA DOCUMENTO =====
        CreateMap<TBNOTADOCTO, TBNOTADOCTODTO>().ReverseMap();

        // ===== CABECERA FACTURA RECURRENTE =====
        CreateMap<TBCABFACREC, TBCABFACRECDto>().ReverseMap();

        // ===== DETALLE FACTURA RECURRENTE =====
        CreateMap<TBDETFACREC, TBDETFACRECDto>().ReverseMap();

        // ===== TIPO DOCUMENTO VENTA =====
        CreateMap<TBTIPODOCVEN, TBTIPODOCVENDTO>().ReverseMap();

        // ===== DOCUMENTO VENTA =====
        CreateMap<TBDOCTOVEN, TBDOCTOVENDTO>().ReverseMap();

        // ===== CABECERA COTIZACION VENTA =====
        CreateMap<TBCABCOTVEN, TBCABCOTVENDTO>().ReverseMap();

        // ===== DETALLE COTIZACION VENTA =====
        CreateMap<TBDETCOTVEN, TBDETCOTVENDTO>().ReverseMap();

        // ===== CABECERA PEDIDO =====
        CreateMap<TBCABPEDIDO, TBCABPEDIDODTO>().ReverseMap();

        // ===== DETALLE PEDIDO =====
        CreateMap<TBDETPEDIDO, TBDETPEDIDODTO>().ReverseMap();

        // ===== CABECERA CONDUCE =====
        CreateMap<TBCABCONDUCE, TBCABCONDUCEDTO>().ReverseMap();

        // ===== DETALLE CONDUCE =====
        CreateMap<TBDETCONDUCE, TBDETCONDUCEDTO>().ReverseMap();

        // ===== DETALLE FACTURA DEVOLUCION =====
        CreateMap<TBDETFACDEV, TBDETFACDEVDTO>().ReverseMap();

        // ===== CUADRE CAJA =====
        CreateMap<TBCUADRECAJA, TBCUADRECAJADTO>().ReverseMap();

        // ===== VALOR CONCEPTO CUADRE =====
        CreateMap<TBVALCPTCUADRE, TBVALCPTCUADREDTO>().ReverseMap();

        // ===== VALOR DENOMINACION CUADRE =====
        CreateMap<TBVALDNMCUADRE, TBVALDNMCUADREDTO>().ReverseMap();

        // ===== CABECERA FACTURA DEVOLUCION =====
        CreateMap<TBCABFACDEV, TBCABFACDEVDTO>().ReverseMap();
    }
}
