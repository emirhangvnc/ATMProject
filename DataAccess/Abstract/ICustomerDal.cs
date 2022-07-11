using EntitiesLayer.Concrete;
using CoreLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}