using IndieGameZone.Domain.RequestsAndResponses.Responses.Platforms;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.GamePlatforms
{
	public class GamePlatformForReturnDto
	{
		public Guid Id { get; init; }
		public string DisplayName { get; init; }
		public double Size { get; init; }
		public virtual PlatformForReturnDto Platform { get; init; }
	}
}
