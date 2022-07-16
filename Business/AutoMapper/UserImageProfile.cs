using AutoMapper;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs.UserImageDTO;

namespace BusinessLayer.AutoMapper
{
    public class UserImageProfile : Profile
    {
        public UserImageProfile()
        {
            CreateMap<UserImageAddDto, UserImage>().ReverseMap();
            CreateMap<UserImageDeleteDto, UserImage>().ReverseMap();
            CreateMap<UserImageUpdateDto, UserImage>().ReverseMap();
        }
    }
}