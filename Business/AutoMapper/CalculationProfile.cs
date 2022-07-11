using AutoMapper;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs.CalculationDTO;

namespace BusinessLayer.AutoMapper
{
    public class CalculationProfile : Profile
    {
        public CalculationProfile()
        {
            CreateMap<CalculationAddDto, Calculation>().ReverseMap();
            CreateMap<CalculationUpdateDto, Calculation>().ReverseMap();
            CreateMap<CalculationDeleteDto, Calculation>().ReverseMap();
        }
    }
}