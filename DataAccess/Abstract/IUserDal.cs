using EntitiesLayer.Concrete;
using CoreLayer.Entities;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}