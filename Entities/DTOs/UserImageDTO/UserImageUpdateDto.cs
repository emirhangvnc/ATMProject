using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.UserImageDTO
{
    public class UserImageUpdateDto : IDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}