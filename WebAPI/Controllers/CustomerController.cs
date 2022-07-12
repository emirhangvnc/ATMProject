using BusinessLayer.Abstract;
using EntitiesLayer.DTOs.CustomerDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetByCustomerId(int customerId)
        {
            var result = _customerService.GetById(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Add(CustomerAddDto customerAddDto)
        {
            var result = _customerService.Add(customerAddDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Delete(CustomerDeleteDto customerDeleteDto)
        {
            var result = _customerService.Delete(customerDeleteDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Update(CustomerUpdateDto customerUpdateDto)
        {
            var result = _customerService.Update(customerUpdateDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}