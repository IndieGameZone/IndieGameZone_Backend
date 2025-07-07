using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GameImages
{
	public class GameImageForUpdateDto
	{
		[Required]
		public string Image { get; init; }
	}
}
