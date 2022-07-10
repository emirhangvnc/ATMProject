using CoreLayer.DataAccess;

namespace EntitiesLayer.Concrete
{
    public class Calculation : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Balance { get; set; }
    }
}