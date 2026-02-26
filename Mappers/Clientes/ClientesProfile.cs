using ApiCm.DTOs.Clientes;
using ApiCm.Entities.Clientes;
using AutoMapper;

namespace ApiCm.Mappers.Clientes;

public class ClientesProfile : Profile
{
    public ClientesProfile()
    {
        // ===== CLIENTE =====
        CreateMap<TBCLIENTE, TBCLIENTEDto>().ReverseMap();

        // ===== CONCEPTO CLIENTE =====
        CreateMap<TBCONCTE, TBCONCTEDto>().ReverseMap();

        // ===== CONTACTO =====
        CreateMap<TBCONTACTO, TBCONTACTODto>().ReverseMap();

        // ===== CLIENTE DEFECTO =====
        CreateMap<TBCTEDEFECTO, TBCTEDEFECTODto>().ReverseMap();

        // ===== CIUDAD =====
        CreateMap<TBCIUDAD, TBCIUDADDto>().ReverseMap();

        // ===== GRUPO CLIENTE =====
        CreateMap<TBGRPOCTE, TBGRPOCTEDto>().ReverseMap();

        // ===== TIPO CLIENTE =====
        CreateMap<TBTIPOCTE, TBTIPOCTEDto>().ReverseMap();

        // ===== TIPO CLIENTE MONEDA =====
        CreateMap<TBTIPOCTEMON, TBTIPOCTEMONDto>().ReverseMap();
    }
}
