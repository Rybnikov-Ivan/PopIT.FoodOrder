using Microsoft.AspNetCore.Builder;
using popIT.FoodOrder.Application.Middleware;

namespace popIT.FoodOrder.Application.Extensions
{
    public static class LoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }
}