using CoreLayer.DataAccess;

namespace EntitiesLayer.Concrete
{
    public class UserImage:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}