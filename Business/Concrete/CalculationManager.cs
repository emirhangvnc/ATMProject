using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using EntitiesLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CalculationManager : ICalculationService
    {
        public IDataResult<List<Calculation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Calculation> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}