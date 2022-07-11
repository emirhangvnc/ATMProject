using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CityDTO
{
    public class CityUpdateDto : IDto
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }
    }
}