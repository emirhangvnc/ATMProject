using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CalculationDTO
{
    public class CalculationUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}