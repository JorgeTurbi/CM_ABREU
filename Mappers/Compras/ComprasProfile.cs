using ApiCm.DTOs.Compras;
using ApiCm.Entities.Compras;
using AutoMapper;

namespace ApiCm.Mappers.Compras;

public class ComprasProfile : Profile
{
    public ComprasProfile()
    {
        // ===== CONCEPTO LIQUIDACION =====
        CreateMap<TBCPTLIQ, TBCPTLIQDto>().ReverseMap();

        // ===== LUGAR ENVIO COMPRA =====
        CreateMap<TBLUGARENVCMP, TBLUGARENVCMPDto>().ReverseMap();

        // ===== TIPO DOCUMENTO COMPRA =====
        CreateMap<TBTIPODOCCMP, TBTIPODOCCMPDto>().ReverseMap();

        // ===== DOCUMENTO COMPRA =====
        CreateMap<TBDOCTOCMP, TBDOCTOCMPDto>().ReverseMap();

        // ===== DETALLE SOLICITUD COTIZACION =====
        CreateMap<TBDETSOLCOT, TBDETSOLCOTDto>().ReverseMap();

        // ===== CABECERA ORDEN COMPRA =====
        CreateMap<TBCABORDCMP, TBCABORDCMPDto>().ReverseMap();

        // ===== DETALLE ORDEN COMPRA =====
        CreateMap<TBDETORDCMP, TBDETORDCMPDto>().ReverseMap();

        // ===== DETALLE DEVOLUCION COMPRA =====
        CreateMap<TBDETCMPDEV, TBDETCMPDEVDto>().ReverseMap();

        // ===== DETALLE LIQUIDACION MERCANCIA =====
        CreateMap<TBDETLIQMER, TBDETLIQMERDto>().ReverseMap();

        // ===== CONCEPTO VALOR LIQUIDACION =====
        CreateMap<TBCPTVALLIQ, TBCPTVALLIQDto>().ReverseMap();

        // ===== CABECERA REQUISICION COMPRA =====
        CreateMap<TBCABREQCMP, TBCABREQCMPDto>().ReverseMap();

        // ===== DETALLE REQUISICION COMPRA =====
        CreateMap<TBDETREQCMP, TBDETREQCMPDto>().ReverseMap();

        // ===== CABECERA SOLICITUD COTIZACION =====
        CreateMap<TBCABSOLCOT, TBCABSOLCOTDto>().ReverseMap();

        // ===== CABECERA DEVOLUCION COMPRA =====
        CreateMap<TBCABCMPDEV, TBCABCMPDEVDto>().ReverseMap();

        // ===== CABECERA LIQUIDACION MERCANCIA =====
        CreateMap<TBCABLIQMER, TBCABLIQMERDto>().ReverseMap();
    }
}
