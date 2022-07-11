using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract.Infos;
using DataAccessLayer.Concrete.Context;
using EntitiesLayer.Concrete.Infos;

namespace DataAccessLayer.Concrete.EntityFramework.Infos
{
    public class EfCityDal : EfEntityRepositoryBase<City, ATMContext>, ICityDal
    {
    }
}