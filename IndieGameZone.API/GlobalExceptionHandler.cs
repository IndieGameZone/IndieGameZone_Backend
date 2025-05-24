using IndieGameZone.Domain.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API
{
	public class GlobalExceptionHandler : IExceptionHandler
	{
		private readonly IProblemDetailsService problemDetailsService;

		public GlobalExceptionHandler(IProblemDetailsService problemDetailsService)
		{
			this.problemDetailsService = problemDetailsService;
		}
		public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
		{
			httpContext.Response.ContentType = "application/json";
			httpContext.Response.StatusCode = exception switch
			{
				BadRequestException => StatusCodes.Status400BadRequest,
				NotAuthenticatedException => StatusCodes.Status401Unauthorized,
				NotEnoughCreditException => StatusCodes.Status402PaymentRequired,
				ForbiddenException => StatusCodes.Status403Forbidden,
				NotFoundException => StatusCodes.Status404NotFound,
				_ => StatusCodes.Status500InternalServerError
			};
			var result = await problemDetailsService.TryWriteAsync(new ProblemDetailsContext
			{
				HttpContext = httpContext,
				ProblemDetails =
				{
					Title = "An error occurred",
					Status = httpContext.Response.StatusCode,
					Detail = exception.Message,
					Type = exception.GetType().Name
				},
				Exception = exception
			});
			if (!result)
			{
				await httpContext.Response.WriteAsJsonAsync(new ProblemDetails
				{
					Title = "An error occurred",
					Status = httpContext.Response.StatusCode,
					Detail = exception.Message,
					Type = exception.GetType().Name
				});
			}
			return true;

		}
	}
}
