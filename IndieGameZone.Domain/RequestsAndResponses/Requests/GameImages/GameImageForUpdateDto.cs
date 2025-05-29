using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GameImages
{
	public class GameImageForUpdateDto
	{
		public IFormFile? Image { get; init; }
	}
}
