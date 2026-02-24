using ApiCm.DTOs.Session;
using ApiCm.Entities;
using AutoMapper;

namespace ApiCm.Mappers;

public class SessionMapper : Profile
{
    public SessionMapper()
    {
        CreateMap<Session, SessionDTO>();

        CreateMap<Session, ActiveSessionDTO>()
            .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.ExpiresAt, opt => opt.MapFrom(src => src.ExpireTokenRequest));
    }
}
