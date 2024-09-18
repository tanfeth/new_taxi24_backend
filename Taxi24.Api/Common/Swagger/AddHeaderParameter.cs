using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace Taxi24.Api.Common.Swagger
{

    public class AddHeaderParameter : IOperationFilter
    {
      

        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "Api-Key",
                In = ParameterLocation.Header,
                Required = true,
                Description = "Api Key"
            });
            //operation.Parameters.Add(new OpenApiParameter
            //{
            //    Name = "Authorization",
            //    In = ParameterLocation.Header,
            //    Required = false,
            //    Description = "Bearer Token"
            //});
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "culture",
                In = ParameterLocation.Header,
                Required = false,
                Description = "en | ar"
            });


        }
    }

}
