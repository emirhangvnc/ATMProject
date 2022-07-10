using CoreLayer.Utilities.Security.JWT;
using EntitiesLayer.Concrete;

namespace BusinessLayer.Helpers
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}