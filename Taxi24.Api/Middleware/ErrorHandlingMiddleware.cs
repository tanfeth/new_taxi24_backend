using Microsoft.AspNetCore.Http;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Common;
using Taxi24.Core.Common.Utlities;

namespace Taxi24.Api.Middleware
{

    public class ErrorHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                context.Response.Headers.Add(ResponseMessageEnum.Status, ex.Message.SetError());
            }
        }
    }
}
