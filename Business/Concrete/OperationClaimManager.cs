using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using EntitiesLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class OperationClaimManager : IOperationClaimService
    {
        public IDataResult<List<OperationClaim>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<OperationClaim> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}