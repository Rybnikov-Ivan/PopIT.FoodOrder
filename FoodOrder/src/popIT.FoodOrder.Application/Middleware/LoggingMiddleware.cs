using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using popIT.FoodOrder.Core.Exceptions;
using popIT.FoodOrder.Core.Exceptions.Response;

namespace popIT.FoodOrder.Application.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception e)
            {
                var response = GetResponse(e);

                context.Response.StatusCode = (int) response.StatusCode;
                context.Response.ContentType = "application/json";

                await context.Response.WriteAsync(response.JsonResponse);

                _logger.LogError(e.Message);
            }
        }

        private ExceptionResponse GetResponse(Exception e)
        {
            switch (e)
            {
                case EntityIdNotFoundException entityIdNotFound:
                {
                    return new ExceptionResponse(JsonSerializer.Serialize(new
                        {
                            entityIdNotFound.Id,
                            entityIdNotFound.ModelName,
                            entityIdNotFound.Message
                        }),
                        HttpStatusCode.NotFound);
                }
                case BadRequestException badRequestException:
                {
                    return new ExceptionResponse(JsonSerializer.Serialize(new
                        {
                            badRequestException.Message
                        }),
                        HttpStatusCode.BadRequest);
                }
                case FoodOrderException universityException:
                {
                    return new ExceptionResponse(JsonSerializer.Serialize(new
                        {
                            universityException.Message
                        }),
                        HttpStatusCode.InternalServerError);
                }
                default:
                {
                    return new ExceptionResponse(JsonSerializer.Serialize(new
                        {
                            e.Message
                        }),
                        HttpStatusCode.InternalServerError);
                }
            }
        }
    }
}