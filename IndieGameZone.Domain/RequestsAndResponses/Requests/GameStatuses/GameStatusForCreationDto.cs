using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GameStatuses
{
	public class GameStatusForCreationDto
	{
		[Required]
		public string Name { get; init; }
	}
}
