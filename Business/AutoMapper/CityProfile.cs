using AutoMapper;
using EntitiesLayer.Concrete.Infos;
using EntitiesLayer.DTOs.CityDTO;

namespace BusinessLayer.AutoMapper
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<CityAddDto, City>().ReverseMap();
            CreateMap<CityUpdateDto, City>().ReverseMap();
            CreateMap<CityDeleteDto, City>().ReverseMap();
        }
    }
}