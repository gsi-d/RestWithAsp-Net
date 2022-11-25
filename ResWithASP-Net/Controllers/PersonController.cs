using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ResWithASP_Net.Model;
using ResWithASP_Net.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResWithASP_Net.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        #region Métodos Pessoa

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return Ok(_personService.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return Ok(_personService.Update(person));
        }

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return NoContent();
        }

        #endregion

        #region Operações Matemáticas

        /*[HttpGet("subtracao/{firstNumber}/{secondNumber}")]
        public IActionResult Subtracao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var subtracao = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(subtracao.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplicacao/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplicacao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var multiplicacao = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(multiplicacao.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("divisao/{firstNumber}/{secondNumber}")]
        public IActionResult Divisao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var divisao = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(divisao.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult Media(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var media = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(media.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("raiz/{firstNumber}")]
        public IActionResult Raiz(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var resultado = Math.Sqrt(Convert.ToDouble(firstNumber));
                return Ok(resultado.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }*/

        #endregion
    }
}
