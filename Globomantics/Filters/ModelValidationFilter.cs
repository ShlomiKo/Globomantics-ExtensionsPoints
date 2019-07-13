using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Globomantics.Filters
{
    public class ModelValidationFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new ViewResult()
                {
                    ViewData = ((Controller)context.Controller).ViewData,
                    TempData = ((Controller)context.Controller).TempData,
                    StatusCode = 400
                };
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Don't use it this time
        }
    }
}
