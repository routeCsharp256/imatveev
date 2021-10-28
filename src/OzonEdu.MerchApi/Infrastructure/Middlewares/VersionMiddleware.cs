using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OzonEdu.MerchApi.Infrastructure.Middlewares
{
    public class VersionMiddleware
    {
        public VersionMiddleware(RequestDelegate next)
        {
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var assembly = Assembly.GetExecutingAssembly().GetName();
            var version = assembly.Version?.ToString() ?? "no version";
            var serviceName = assembly.Name?.ToString() ?? "no name";
            var jsonObject = JsonSerializer.Serialize(new { version = version, serviceName = serviceName });
            await context.Response.WriteAsync(jsonObject);
        }
    }
}