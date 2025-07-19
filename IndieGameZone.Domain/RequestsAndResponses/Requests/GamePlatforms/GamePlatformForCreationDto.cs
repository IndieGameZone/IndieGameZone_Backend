using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms
{
	public class GamePlatformForCreationDto
	{
		[Required]
		public Guid PlatformId { get; init; }
		[Required]
		public string File { get; init; }
		[Required]
		[MaxLength(150)]
		public string Version { get; init; }
	}
}
