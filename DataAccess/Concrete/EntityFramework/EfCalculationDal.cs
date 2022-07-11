using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntitiesLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCalculationDal : EfEntityRepositoryBase<Calculation, ATMContext>, ICalculationDal
    {
    }
}