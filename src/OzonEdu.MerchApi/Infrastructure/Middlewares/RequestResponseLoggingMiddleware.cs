using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace OzonEdu.MerchApi.Infrastructure.Middlewares
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestResponseLoggingMiddleware> _logger;

        public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await LogRequest(context);
            await _next(context);
            await LogResponse(context);
        }

        private async Task LogRequest(HttpContext context)
        {
            var headers = context.Request.Headers.ToString();
            var host = context.Request.Host;
            var route = context.Request.Path;
            _logger.LogInformation($"Headers: {headers}{Environment.NewLine}Route: {host}{route}");
        }
        
        private async Task LogResponse(HttpContext context)
        {
            var headers = context.Request.Headers.ToString();
            var host = context.Request.Host;
            var route = context.Request.Path;
            _logger.LogInformation($"Headers: {headers}{Environment.NewLine}Route: {host}{route}");
        }
    }
}