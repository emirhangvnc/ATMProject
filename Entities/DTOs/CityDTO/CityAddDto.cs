using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CityDTO
{
    public class CityAddDto:IDto
    {
        public string CityName { get; set; }
        public string CityCode { get; set; }
    }
}