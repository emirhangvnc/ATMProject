using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.ColorDto
{
    public class CalculationUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}