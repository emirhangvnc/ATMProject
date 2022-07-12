using AutoMapper;
using EntitiesLayer.Concrete.Infos;
using EntitiesLayer.DTOs.CountryDTO;

namespace BusinessLayer.AutoMapper
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<CountryAddDto, Country>().ReverseMap();
            CreateMap<CountryUpdateDto, Country>().ReverseMap();
            CreateMap<CountryDeleteDto, Country>().ReverseMap();
        }
    }
}