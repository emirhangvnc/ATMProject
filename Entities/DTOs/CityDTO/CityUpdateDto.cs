using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CityDTO
{
    public class CityUpdateDto : CityAddDto,IDto
    {
        public int Id { get; set; }
    }
}