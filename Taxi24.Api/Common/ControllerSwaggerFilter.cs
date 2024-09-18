using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Taxi24.Api.Common
{
    public class ControllerSwaggerFilter : IDocumentFilter
    {
        private readonly IEnumerable<string> _includedControllers;

        public ControllerSwaggerFilter(IEnumerable<string> includedControllers)
        {
            _includedControllers = includedControllers ?? Enumerable.Empty<string>();
        }

        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            // Remove paths not related to included controllers
            var keysToRemove = swaggerDoc.Paths.Keys
                .Where(key => !_includedControllers.Any(controller => key.StartsWith($"/api/{controller}")))
                .ToList();

            foreach (var key in keysToRemove)
            {
                swaggerDoc.Paths.Remove(key);
            }
        }
    }
}
