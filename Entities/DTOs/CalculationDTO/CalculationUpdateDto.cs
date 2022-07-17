using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CalculationDTO
{
    public class CalculationUpdateDto : CalculationAddDto,IDto
    {
        public int Id { get; set; }
    }
}