using Globomantics.Filters;
using Microsoft.AspNetCore.Mvc;
using Globomantics.Services;

namespace Globomantics.Controllers
{
    [Route("api/[controller]")]
    [RateExceptionFilter]
    public class RatesController : Controller
    {
        private IRateService rateService;

        public RatesController(IRateService rateService)
        {
            this.rateService = rateService;
        }

        [HttpGet]
        [Route("mortgage")]
        public IActionResult GetMortgageRates()
        {
            return Ok(rateService.GetMortgageRates());
        }

        [HttpGet]
        [Route("autoloan")]
        public IActionResult GetAutoLoanRates()
        {
            return Ok(rateService.GetAutoLoanRates());
        }

        [HttpGet]
        [Route("creditcard")]
        public IActionResult GetCreditCardRates()
        {
            return Ok(rateService.GetCreditCardRates());
        }


        [HttpGet]
        [Route("cd")]
        public IActionResult GetCDRates()
        {
            return Ok(rateService.GetCDRates());
        }
    }
}