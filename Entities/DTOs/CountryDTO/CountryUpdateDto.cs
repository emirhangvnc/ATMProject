using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CountryDTO
{
    public class CountryUpdateDto : IDto
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}