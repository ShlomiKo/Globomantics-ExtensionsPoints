using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Globomantics.Filters
{
    public class FeatureAuthFilter : IAuthorizationFilter
    {
        private IFeatureService _featureService;
        private string _featureName;

        public FeatureAuthFilter(IFeatureService featureService, string featureName)
        {
            _featureService = featureService;
            _featureName = featureName;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!_featureService.IsFeatureActive(_featureName))
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }
}