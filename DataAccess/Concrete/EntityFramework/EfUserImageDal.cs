using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntitiesLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfUserImageDal : EfEntityRepositoryBase<UserImage, ATMContext>, IUserImageDal
    {
    }
}