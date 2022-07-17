using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.General;
using BusinessLayer.ValidationRules.Entities.UserImageValidator;
using Core.Utilities.Helpers.FileHelper;
using CoreLayer.Aspects.Validation;
using CoreLayer.Utilities.Business;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs.UserImageDTO;
using Microsoft.AspNetCore.Http;

namespace BusinessLayer.Concrete
{
    public class UserImageManager : IUserImageService
    {
        IUserImageDal _userImageDal;
        readonly IMapper _mapper;
        public UserImageManager(IUserImageDal userImageDal,IMapper mapper)
        {
            _userImageDal = userImageDal;
            _mapper = mapper;
        }

        public IDataResult<List<UserImage>> GetAll()
        {
            return new SuccessDataResult<List<UserImage>>(_userImageDal.GetAll(), UserImageMessagesTR.UserImagesListed);
        }

        public IDataResult<UserImage> GetById(int id)
        {
            return new SuccessDataResult<UserImage>(_userImageDal.Get(u=>u.Id==id), UserImageMessagesTR.UserImageListed);
        }
        [ValidationAspect(typeof(UserImageAddDtoValidator))]
        public IResult Add(IFormFile file,UserImageAddDto addedDto)
        {
            IResult result = BusinessRules.Run(
                CheckIfImageExtensionValid(file)
                );

            if (result != null)
                return result;

            var image = _mapper.Map<UserImage>(addedDto);
            image.ImagePath = FileHelper.Add(file);
            image.Date = DateTime.Now;
            _userImageDal.Add(image);
            return new SuccessResult(UserImageMessagesTR.UserImageAdded);
        }
        [ValidationAspect(typeof(UserImageDeleteDtoValidator))]
        public IResult Delete(IFormFile file, UserImageDeleteDto deletedDto)
        {
            IResult result = BusinessRules.Run(
               CheckIfImageExists(deletedDto.Id)
               );
            if (result != null)
                return result;

            var userImage = _mapper.Map<UserImage>(deletedDto);
            string path = GetById(deletedDto.Id).Data.ImagePath;
            FileHelper.Delete(path);
            _userImageDal.Delete(userImage);
            return new SuccessResult(UserImageMessagesTR.UserImageDeleted);
        }
        [ValidationAspect(typeof(UserImageUpdateDtoValidator))]
        public IResult Update(IFormFile file, UserImageUpdateDto updatedDto)
        {
            IResult result = BusinessRules.Run(
                CheckIfImageExtensionValid(file),
                CheckIfImageExists(updatedDto.Id)
                );

            if (result != null)
                return result;

            var userImage=_mapper.Map<UserImage>(updatedDto);
            var oldUserImage = GetById(userImage.Id).Data;
            userImage.ImagePath = FileHelper.Update(file, oldUserImage.ImagePath);
            userImage.Date = DateTime.Now;
            _userImageDal.Update(userImage);
            return new SuccessResult(UserImageMessagesTR.UserImageUpdated);
        }

        private IResult CheckIfImageExtensionValid(IFormFile file)
        {
            bool isValidFileExtension = GeneralConstantsTR.ValidImageFileTypes.Any(t => t == Path.GetExtension(file.FileName).ToUpper());
            if (!isValidFileExtension)
                return new ErrorResult(UserImageMessagesTR.InvalidImageExtension);
            return new SuccessResult();
        }
        private IResult CheckIfImageExists(int id)
        {
            if (_userImageDal.IsExist(id))
                return new SuccessResult();
            return new ErrorResult(UserImageMessagesTR.UserImageMustBeExists);
        }
    }
}