using IndieGameZone.Domain.RequestsAndResponses.Responses.GamePlatforms;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
	public class PlatformFileDto
	{
		public string InstallInstruction { get; init; }
		public virtual ICollection<GamePlatformForReturnDto> GamePlatforms { get; init; }
	}
}
