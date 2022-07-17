using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntitiesLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfUserImageDal : EfEntityRepositoryBase<UserImage, ATMContext>, IUserImageDal
    {
        public bool IsExist(int id)
        {
            using (ATMContext context = new ATMContext())
            {
                return context.UserImages.Any(p => p.Id == id);
            }
        }
    }
}