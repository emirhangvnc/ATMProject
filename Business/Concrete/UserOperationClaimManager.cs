using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using EntitiesLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        public IDataResult<List<UserOperationClaim>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserOperationClaim> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}