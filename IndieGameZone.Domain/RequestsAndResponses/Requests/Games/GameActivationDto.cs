using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Games
{
	public class GameActivationDto
	{
		public CensorStatus CensorStatus { get; init; }
		public string? CensorReason { get; init; }
	}
}
