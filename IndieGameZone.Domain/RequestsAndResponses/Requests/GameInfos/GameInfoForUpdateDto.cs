using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GameInfos
{
	public class GameInfoForUpdateDto
	{
		public IFormFile? Image { get; init; }
		public string? Title { get; init; }
		public string? Description { get; init; }
	}
}
