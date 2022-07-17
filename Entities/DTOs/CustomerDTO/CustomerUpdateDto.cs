using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.CustomerDTO
{
    public class CustomerUpdateDto:CustomerAddDto,IDto
    {
        public int Id { get; set; }
    }
}