using BusinessLayer.Abstract;
using BusinessLayer.Constants.TR;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserImageManager : IUserImageService
    {
        IUserImageDal _userImageDal;
        public UserImageManager(IUserImageDal userImageDal)
        {
            _userImageDal = userImageDal;
        }

        public IDataResult<List<UserImage>> GetAll()
        {
            return new SuccessDataResult<List<UserImage>>(_userImageDal.GetAll(), UserImageMessages.UserImagesListed);
        }

        public IDataResult<UserImage> GetById(int id)
        {
            return new SuccessDataResult<UserImage>(_userImageDal.Get(u=>u.Id==id), UserImageMessages.UserImageListed);

        }
    }
}