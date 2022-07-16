using AutoMapper;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs.CustomerDTO;

namespace BusinessLayer.AutoMapper
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerAddDto, Customer>().ReverseMap();
            CreateMap<CustomerDeleteDto, Customer>().ReverseMap();
            CreateMap<CustomerUpdateDto, Customer>().ReverseMap();
        }
    }
}