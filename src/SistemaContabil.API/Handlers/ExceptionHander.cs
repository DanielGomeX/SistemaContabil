using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

namespace SistemaContabil.API.Handlers
{
    public class ExceptionHander
    {
        public async Task Invoke(HttpContext context)
        {
            var httpStatus = HttpStatusCode.InternalServerError;

            var exception = context.Features.Get<IExceptionHandlerFeature>()?.Error;
            if (exception != null)
            {
                context.Response.Headers["Access-Control-Allow-Origin"] = "*";
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)httpStatus;

                //Log.Fatal(exception.ToString());

                await context.Response.WriteAsync(JsonConvert.SerializeObject(new
                {
                    ErroMessage = exception.Message,

                    Status = httpStatus
                }));
            }
        }
    }
}
