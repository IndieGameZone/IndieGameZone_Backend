using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms
{
	public class GamePlatformForCreationDto
	{
		public Guid PlatformId { get; init; }
		public IFormFile File { get; init; }
	}
}
