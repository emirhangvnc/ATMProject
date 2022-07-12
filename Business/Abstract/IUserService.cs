using BusinessLayer.Abstract.Base;
using CoreLayer.Utilities.Results;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs.UserDTO;

namespace BusinessLayer.Abstract
{
    public interface IUserService : IBaseService<User>, IAddDtoService<UserAddDto>,
        IDeleteDtoService<UserDeleteDto>, IUpdatedDtoService<UserUpdateDto>
    {
        IDataResult<List<OperationClaim>> GetClaims(int id);
        IDataResult<User> GetByMail(string email);
    }
}