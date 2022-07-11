using EntitiesLayer.Concrete;
using CoreLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}