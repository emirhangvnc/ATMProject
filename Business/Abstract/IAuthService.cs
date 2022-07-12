using CoreLayer.Utilities.Results;
using CoreLayer.Utilities.Security.JWT;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs.AuthDTO;

namespace BusinessLayer.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}