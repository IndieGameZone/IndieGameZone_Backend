using IndieGameZone.Domain.RequestsAndResponses.Responses.Platforms;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.GamePlatforms
{
	public class GamePlatformWithoutFileForReturnDto
	{
		public string DisplayName { get; init; }
		public double Size { get; init; }
		public virtual PlatformForReturnDto Platform { get; init; }
		public string Version { get; init; }
	}
}
