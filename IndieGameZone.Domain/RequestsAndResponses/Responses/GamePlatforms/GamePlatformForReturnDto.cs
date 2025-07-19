using IndieGameZone.Domain.RequestsAndResponses.Responses.Platforms;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.GamePlatforms
{
	public class GamePlatformForReturnDto
	{
		public Guid Id { get; init; }
		public string DisplayName { get; init; }
		public string Version { get; init; }
		public double Size { get; init; }
		public string File { get; init; }
		public bool IsActive { get; init; }
		public virtual PlatformForReturnDto Platform { get; init; }
	}
}
