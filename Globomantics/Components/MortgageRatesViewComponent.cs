﻿using System.Threading.Tasks;
using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;

namespace Globomantics.Components
{
    public class MortgageRatesViewComponent : ViewComponent
    {
        private readonly IRateService _rateService;

        public MortgageRatesViewComponent(IRateService rateService)
        {
            _rateService = rateService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var rates = _rateService.GetMortgageRates();

            return View(rates);
        }
    }
}
