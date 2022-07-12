using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CustomerDTO
{
    public class CustomerUpdateDto:IDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
    }
}