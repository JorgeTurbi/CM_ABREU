using ApiCm.DTOs.User;
using ApiCm.Entities;
using AutoMapper;

namespace ApiCm.Mappers;

public class UserMapper : Profile
{
    public UserMapper()
    {
        CreateMap<User, UserDTO>();
        CreateMap<User, UserProfileDTO>();
    }
}
