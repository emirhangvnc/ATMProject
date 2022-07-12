using CoreLayer.DataAccess;

namespace EntitiesLayer.Concrete
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}