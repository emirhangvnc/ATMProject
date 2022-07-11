using EntitiesLayer.Concrete;
using CoreLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface ICalculationDal : IEntityRepository<Calculation>
    {
    }
}