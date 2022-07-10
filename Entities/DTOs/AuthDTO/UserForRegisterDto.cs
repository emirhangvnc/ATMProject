using CoreLayer.Entities;

namespace EntitiesLayer.DTOs.AuthDTO
{
    public class UserForRegisterDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}