using EntitiesLayer.Concrete;
using CoreLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IUserImageDal : IEntityRepository<UserImage>
    {
        public bool IsExist(int id);
    }
}