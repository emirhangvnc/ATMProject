using CoreLayer.DataAccess.EntityFramework;
using DataAccess.Abstract.Infos;
using DataAccessLayer.Concrete.Context;
using EntitiesLayer.Concrete.Infos;

namespace DataAccess.Concrete.EntityFramework.Infos
{
    public class EfCityDal : EfEntityRepositoryBase<City, ATMContext>, ICityDal
    {
    }
}