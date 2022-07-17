using BusinessLayer.Abstract.Base;
using CoreLayer.Utilities.Results;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs.UserImageDTO;
using Microsoft.AspNetCore.Http;

namespace BusinessLayer.Abstract
{
    public interface IUserImageService : IBaseService<UserImage>
    {
        IResult Add(IFormFile formFile, UserImageAddDto addDto);
        IResult Delete(IFormFile formFile, UserImageDeleteDto deleteDto);
        IResult Update(IFormFile formFile, UserImageUpdateDto updateDto);
    }
}