using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class LibrariesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public LibrariesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("users/{userId:guid}/libraries")]
		public async Task<IActionResult> GetUserLibraries([FromRoute] Guid userId, [FromQuery] LibraryParameters libraryParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.LibraryService.GetLibrariesByUserId(userId, libraryParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.libraries);
		}
	}
}
