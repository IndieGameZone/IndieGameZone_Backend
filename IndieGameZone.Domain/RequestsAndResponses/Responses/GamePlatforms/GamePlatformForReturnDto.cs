using IndieGameZone.Domain.RequestsAndResponses.Responses.Platforms;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.GamePlatforms
{
	public class GamePlatformForReturnDto
	{
		public string DisplayName { get; init; }
		public double Size { get; init; }
		public string File { get; init; }
		public virtual PlatformForReturnDto Platform { get; init; }
	}
}
