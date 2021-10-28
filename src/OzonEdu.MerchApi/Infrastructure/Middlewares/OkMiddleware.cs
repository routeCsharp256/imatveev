using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OzonEdu.MerchApi.Infrastructure.Middlewares
{
    public class OkMiddleware
    {
        public OkMiddleware(RequestDelegate next)
        {
        }

        public async Task InvokeAsync(HttpContext context)
            => await context.Response.CompleteAsync()/*.WriteAsync(version)*/;
    }
}