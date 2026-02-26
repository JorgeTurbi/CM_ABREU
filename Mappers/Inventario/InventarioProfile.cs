using ApiCm.DTOs.Inventario;
using ApiCm.Entities.Inventario;
using AutoMapper;

namespace ApiCm.Mappers.Inventario;

public class InventarioProfile : Profile
{
    public InventarioProfile()
    {
        // ===== PRODUCTO =====
        CreateMap<TBPRODUCTO, TBPRODUCTODto>().ReverseMap();

        // ===== PRODUCTO - ALMACEN =====
        CreateMap<TBPRDALM, TBPRDALMDto>().ReverseMap();

        // ===== UNIDAD PRECIO PRODUCTO =====
        CreateMap<TBUNDPRCPRD, TBUNDPRCPRDDto>().ReverseMap();

        // ===== TIPO INVENTARIO =====
        CreateMap<TBTIPOINV, TBTIPOINVDto>().ReverseMap();

        // ===== DIVISION =====
        CreateMap<TBDIVISION, TBDIVISIONDto>().ReverseMap();

        // ===== CLASE =====
        CreateMap<TBCLASE, TBCLASEDto>().ReverseMap();

        // ===== MARCA =====
        CreateMap<TBMARCA, TBMARCADto>().ReverseMap();

        // ===== UNIDAD MEDIDA =====
        CreateMap<TBUNDMEDIDA, TBUNDMEDIDADto>().ReverseMap();

        // ===== CONCEPTO INVENTARIO =====
        CreateMap<TBCPTINV, TBCPTINVDto>().ReverseMap();

        // ===== PRODUCTO DEFECTO =====
        CreateMap<TBPRDDEFECTO, TBPRDDEFECTODto>().ReverseMap();

        // ===== DETALLE ENTRADA/SALIDA =====
        CreateMap<TBDETENTSAL, TBDETENTSALDto>().ReverseMap();

        // ===== INVENTARIO FISICO =====
        CreateMap<TBINVFISICO, TBINVFISICODto>().ReverseMap();

        // ===== CABECERA INVENTARIO FISICO =====
        CreateMap<TBCABINVFIS, TBCABINVFISDto>().ReverseMap();

        // ===== DETALLE INVENTARIO FISICO =====
        CreateMap<TBDETINVFIS, TBDETINVFISDto>().ReverseMap();

        // ===== DETALLE CAMBIO PRECIO =====
        CreateMap<TBDETCMBPRC, TBDETCMBPRCDto>().ReverseMap();

        // ===== REFERENCIA MULTIPLE =====
        CreateMap<TBREFMULTIPLE, TBREFMULTIPLEDto>().ReverseMap();

        // ===== ALMACEN =====
        CreateMap<TBALMACEN, TBALMACENDto>().ReverseMap();

        // ===== CONFIGURACION PRECIO =====
        CreateMap<TBCFGPRECIO, TBCFGPRECIODto>().ReverseMap();

        // ===== CABECERA ENTRADA/SALIDA =====
        CreateMap<TBCABENTSAL, TBCABENTSALDto>().ReverseMap();

        // ===== CABECERA TRANSFERENCIA PRODUCTO =====
        CreateMap<TBCABTRFPRD, TBCABTRFPRDDto>().ReverseMap();

        // ===== DETALLE TRANSFERENCIA PRODUCTO =====
        CreateMap<TBDETTRFPRD, TBDETTRFPRDDto>().ReverseMap();

        // ===== CABECERA CAMBIO PRECIO =====
        CreateMap<TBCABCMBPRC, TBCABCMBPRCDto>().ReverseMap();
    }
}
