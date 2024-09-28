using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // Add method: GET api/calculator/add?num1={value}&num2={value}
        [HttpGet("add")]
        public ActionResult<decimal> Add(decimal num1, decimal num2)
        {
            return Ok(num1 + num2);
        }

        // Subtract method: GET api/calculator/subtract?num1={value}&num2={value}
        [HttpGet("subtract")]
        public ActionResult<decimal> Subtract(decimal num1, decimal num2)
        {
            return Ok(num1 - num2);
        }

        // Multiply method: GET api/calculator/multiply?num1={value}&num2={value}
        [HttpGet("multiply")]
        public ActionResult<decimal> Multiply(decimal num1, decimal num2)
        {
            return Ok(num1 * num2);
        }

        // Divide method: GET api/calculator/divide?num1={value}&num2={value}
        [HttpGet("divide")]
        public ActionResult<decimal> Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Division by zero is not allowed.");
            }
            return Ok(num1 / num2);
        }

        // Modulo method: GET api/calculator/modulo?num1={value}&num2={value}
        [HttpGet("modulo")]
        public ActionResult<decimal> Modulo(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Modulo by zero is not allowed.");
            }
            return Ok(num1 % num2);
        }
    }
}
