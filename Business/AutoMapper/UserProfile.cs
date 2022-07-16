using AutoMapper;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs.UserDTO;

namespace BusinessLayer.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserAddDto, User>().ReverseMap();
            CreateMap<UserDeleteDto, User>().ReverseMap();
            CreateMap<UserUpdateDto, User>().ReverseMap();
        }
    }
}