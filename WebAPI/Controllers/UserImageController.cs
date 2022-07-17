using BusinessLayer.Abstract;
using EntitiesLayer.DTOs.UserImageDTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserImageController : ControllerBase
    {
        IUserImageService _userImageService;

        public UserImageController(IUserImageService userImageService)
        {
            _userImageService = userImageService;
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAll()
        {
            var result = _userImageService.GetAll();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetByUserImageId(int userImageId)
        {
            var result = _userImageService.GetById(userImageId);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult Upload(IFormFile file,UserImageAddDto userImageAddDto)
        {
            var result = _userImageService.Add(file,userImageAddDto);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult Delete(IFormFile file, UserImageDeleteDto userImageDeleteDto)
        {
            var result = _userImageService.Delete(file,userImageDeleteDto);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult Update(IFormFile file, UserImageUpdateDto userImageUpdateDto)
        {
            var result = _userImageService.Update(file,userImageUpdateDto);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}