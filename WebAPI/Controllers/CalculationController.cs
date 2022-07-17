using BusinessLayer.Abstract;
using EntitiesLayer.DTOs.CalculationDTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        ICalculationService _calculationService;

        public CalculationController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAll()
        {
            var result = _calculationService.GetAll();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetByCalculationId(int calculationId)
        {
            var result = _calculationService.GetById(calculationId);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}