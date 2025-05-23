using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GameStatuses
{
	public class GameStatusForUpdateDto
	{
		[Required]
		public string Name { get; init; }
	}
}
