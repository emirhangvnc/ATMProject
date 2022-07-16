using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CalculationDTO
{
    public class CalculationUpdateDto : IDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Balance { get; set; }
    }
}