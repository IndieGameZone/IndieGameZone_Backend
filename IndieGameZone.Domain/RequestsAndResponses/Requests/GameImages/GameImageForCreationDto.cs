using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GameImages
{
	public class GameImageForCreationDto
	{
		public IFormFile? Image { get; init; }
	}
}
