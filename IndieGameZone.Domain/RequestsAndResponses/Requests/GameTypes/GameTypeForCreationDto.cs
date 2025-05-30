using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GameTypes
{
	public class GameTypeForCreationDto
	{
		[Required]
		public string Name { get; init; }
	}
}
