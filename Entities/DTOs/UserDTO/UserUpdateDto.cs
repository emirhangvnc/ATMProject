using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.UserDTO
{
    public class UserUpdateDto : UserAddDto,IDto
    {
        public int Id { get; set; }
    }
}