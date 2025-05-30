using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GameTypes
{
	public class GameTypeForUpdateDto
	{
		[Required]
		public string Name { get; init; }
	}
}
