using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using EntitiesLayer.Concrete;
using DataAccessLayer.Abstract;
using BusinessLayer.Constants.TR;
using BusinessLayer.Abstract.Base;
using EntitiesLayer.DTOs.UserDTO;
using BusinessLayer.Constants.TR.Base;
using AutoMapper;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IMapper _mapper;
        public UserManager(IUserDal userDal,IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),UserMessages.UsersListed);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id),UserMessages.UserListed);
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }

        public IDataResult<List<OperationClaim>> GetClaims(int id)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(id));
        }

        //[ValidationAspect(typeof(CustomerAddDtoValidator))]
        public IResult Add(UserAddDto addedDto)
        {
            var result = _userDal.Get(c => c.Email == addedDto.Email);
            if (result != null)
                return new ErrorResult($"Böyle Bir {UserMessages.User} {BaseConstants.AlreadyAvailable}");

            var user = _mapper.Map<User>(addedDto);
            _userDal.Add(user);
            return new SuccessResult(UserMessages.UserAdded);
        }

        //[ValidationAspect(typeof(CustomerDeleteDtoValidator))]
        public IResult Delete(UserDeleteDto deletedDto)
        {
            var result = _userDal.Get(c => c.Id == deletedDto.Id);
            if (result == null)
                return new ErrorResult(UserMessages.UserNotFound);

            _userDal.Delete(result);
            return new SuccessResult(UserMessages.UserDeleted);
        }

        //[ValidationAspect(typeof(CustomerUpdateDtoValidator))]
        public IResult Update(UserUpdateDto updatedDto)
        {
            var result = _userDal.Get(c => c.Id == updatedDto.Id);
            if (result == null)
                return new ErrorResult(UserMessages.UserNotFound);

            var user = _mapper.Map(updatedDto, result);
            _userDal.Update(user);
            return new SuccessResult(UserMessages.UserUpdated);
        }
    }
}