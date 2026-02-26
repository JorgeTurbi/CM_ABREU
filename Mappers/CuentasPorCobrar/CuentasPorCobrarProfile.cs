using ApiCm.DTOs.CuentasPorCobrar;
using ApiCm.Entities.CuentasPorCobrar;
using AutoMapper;

namespace ApiCm.Mappers.CuentasPorCobrar;

public class CuentasPorCobrarProfile : Profile
{
    public CuentasPorCobrarProfile()
    {
        // ===== TIPO DOCUMENTO CXC =====
        CreateMap<TBTIPODOCCXC, TBTIPODOCCXCDto>().ReverseMap();

        // ===== DOCUMENTO CXC =====
        CreateMap<TBDOCTOCXC, TBDOCTOCXCDto>().ReverseMap();

        // ===== CABECERA MOVIMIENTO CXC =====
        CreateMap<TBCABMOVCXC, TBCABMOVCXCDto>().ReverseMap();

        // ===== DETALLE MOVIMIENTO CXC =====
        CreateMap<TBDETMOVCXC, TBDETMOVCXCDto>().ReverseMap();

        // ===== CABECERA RECIBO =====
        CreateMap<TBCABRECIBO, TBCABRECIBODto>().ReverseMap();

        // ===== DETALLE RECIBO =====
        CreateMap<TBDETRECIBO, TBDETRECIBODto>().ReverseMap();

        // ===== CXC ACTUAL =====
        CreateMap<TBCXCACT, TBCXCACTDto>().ReverseMap();

        // ===== CXC HISTORICO =====
        CreateMap<TBCXCHIS, TBCXCHISDto>().ReverseMap();
    }
}
