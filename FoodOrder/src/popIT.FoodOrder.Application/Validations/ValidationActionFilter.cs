using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace popIT.FoodOrder.Application.Validations
{
	public class ValidationActionFilter : IActionFilter
	{
		private readonly ILogger<ValidationActionFilter> _logger;

		public ValidationActionFilter(ILogger<ValidationActionFilter> logger)
		{
			_logger = logger;
		}

		public void OnActionExecuted(ActionExecutedContext context)
		{

		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			if (!context.ModelState.IsValid)
			{
				var errorMessages = new SerializableError(context.ModelState);
				var errors = JsonConvert.SerializeObject(new
				{
					Errors = errorMessages
				});
				_logger.LogError(errors);
				context.Result = new ContentResult
				{
					ContentType = "application/json",
					StatusCode = StatusCodes.Status400BadRequest,
					Content = errors
				};
			}
		}
	}
}
