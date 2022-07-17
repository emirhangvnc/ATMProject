using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.UserImageDTO
{
    public class UserImageUpdateDto : UserImageAddDto,IDto
    {
        public int Id { get; set; }
    }
}