using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms
{
	public class GamePlatformForUpdateDto
	{
		public Guid PlatformId { get; init; }
		public IFormFile? File { get; init; }
	}
}
