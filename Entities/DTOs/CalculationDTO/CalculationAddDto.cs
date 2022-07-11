using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CalculationDTO
{
    public class CalculationAddDto : IDto
    {
        public int CustomerId { get; set; }
        public decimal Balance { get; set; }
    }
}