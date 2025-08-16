using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms
{
	public class GamePlatformForUpdateDto
	{
		[Required]
		public Guid PlatformId { get; init; }
		[Required]
		public string? File { get; init; }
		[Required]
		[MaxLength(150)]
		public string Version { get; init; }
		[Required]
		public string DisplayName { get; init; }
		[Required]
		public string FilePassword { get; init; }
	}
}
