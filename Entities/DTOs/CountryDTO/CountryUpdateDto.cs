using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CountryDTO
{
    public class CountryUpdateDto : CountryAddDto,IDto
    {
        public int Id { get; set; }
    }
}