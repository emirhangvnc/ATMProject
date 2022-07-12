using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using EntitiesLayer.Concrete;
using DataAccessLayer.Abstract;
using BusinessLayer.Constants.TR;

namespace BusinessLayer.Concrete
{
    public class CalculationManager : ICalculationService
    {
        ICalculationDal _calculationDal;
        public CalculationManager(ICalculationDal calculationDal)
        {
            _calculationDal= calculationDal;
        }
        public IDataResult<List<Calculation>> GetAll()
        {
            return new SuccessDataResult<List<Calculation>>(_calculationDal.GetAll(), CalculationMessages.CalculationsListed);
        }

        public IDataResult<Calculation> GetById(int id)
        {
            return new SuccessDataResult<Calculation>(_calculationDal.Get(c => c.Id == id), CalculationMessages.CalculationListed);

        }
    }
}