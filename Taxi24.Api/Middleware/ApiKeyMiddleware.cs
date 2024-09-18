using Microsoft.AspNetCore.Http;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Common;
using Taxi24.Core.Common.Utlities;

namespace Taxi24.Api.Middleware
{

    public class ApiKeyMiddleware : IMiddleware
    {
        string key = "IzVqc7xBjNiYQS0Nl6QXIXSX8WBsd0Hwjfe9jVQs";

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
           
            if (!context.Request.Headers.TryGetValue("Api-Key", out var claimsApiKey))
            {
                string errorMessage = "Api Key is null";
                context.Response.Headers.Add(ResponseMessageEnum.Status, errorMessage.SetError());
                return;
            }
            if (!claimsApiKey.ToString().Equals(key, StringComparison.InvariantCultureIgnoreCase))
            {
                string errorMessage = "InValid Api key";
                context.Response.Headers.Add(ResponseMessageEnum.Status, errorMessage.SetError());
                return;
            }

            await next(context);
        }
    }
}
