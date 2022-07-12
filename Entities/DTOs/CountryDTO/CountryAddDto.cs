using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CountryDTO
{
    public class CountryAddDto : IDto
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}