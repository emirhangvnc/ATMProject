using CoreLayer.Utilities.Security.JWT;
using EntitiesLayer.Concrete;
using EntitiesLayer.Concrete.Infos;

namespace BusinessLayer.Helpers
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}