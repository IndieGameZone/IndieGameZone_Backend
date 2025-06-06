namespace IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms
{
	public class GamePlatformForUpdateDto
	{
		public Guid PlatformId { get; init; }
		public string? File { get; init; }
	}
}
