using AutoMapper;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs.AuthDTO;

namespace BusinessLayer.AutoMapper
{
    public class AuthProfile : Profile
    {
        public AuthProfile()
        {
            CreateMap<UserForRegisterDto, User>().ReverseMap();
        }
    }
}