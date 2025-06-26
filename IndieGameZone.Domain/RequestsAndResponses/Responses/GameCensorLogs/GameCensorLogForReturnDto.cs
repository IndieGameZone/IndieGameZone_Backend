using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.GameCensorLogs
{
	public class GameCensorLogForReturnDto
	{
		public Guid Id { get; init; }
		public DateTime CreatedAt { get; init; }
		public DateTime? CensoredAt { get; init; }
		public string? CensorReason { get; init; }
		public CensorStatus CensorStatus { get; init; }
		public virtual UserShortForReturnDto? Moderator { get; init; }
	}
}
