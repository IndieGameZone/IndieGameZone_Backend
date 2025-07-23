using IndieGameZone.Domain.RequestsAndResponses.Responses.Platforms;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.GamePlatforms
{
	public class GamePlatformWithoutFileForReturnDto
	{
		public Guid Id { get; init; }
		public string DisplayName { get; init; }
		public double Size { get; init; }
		public virtual PlatformForReturnDto Platform { get; init; }
		public string Version { get; init; }
		public bool IsActive { get; init; }
		public DateTime CreatedAt { get; init; }
	}
}
