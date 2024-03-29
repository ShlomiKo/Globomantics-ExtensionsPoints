﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Globomantics.Core.Models;
using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;

namespace Globomantics.Components
{
    public class CreditCardRatesViewComponent : ViewComponent
    {
        private readonly IRateService _rateService;

        public CreditCardRatesViewComponent(IRateService rateService)
        {
            _rateService = rateService;
        }

        public async Task<IViewComponentResult> InvokeAsync(
            string title, string subtitle)
        {
            var ratesVM = new CreditCardWidgetVM()
            {
                Rates = _rateService.GetCreditCardRates(),
                WidgetTitle = title,
                WidgetSubTitle = subtitle
            };

            return View(ratesVM);
        }
    }

    // TODO: Move to external class
    public class CreditCardWidgetVM
    {
        public string WidgetTitle { get; set; }
        public string WidgetSubTitle { get; set; }
        public List<Rate> Rates { get; set; }
    }
}
