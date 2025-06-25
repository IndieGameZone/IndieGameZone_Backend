using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.Entities
{
	public class GameCensorLogs
	{
		public Guid Id { get; set; }
		public DateTime CensoredAt { get; set; }
		public string? CensorReason { get; set; }
		public CensorStatus CensorStatus { get; set; }
		public Guid GameId { get; set; }
		public Guid? ModeratorId { get; set; }

		// Navigation Properties
		public virtual Games Game { get; set; } = null!;
		public virtual Users? Moderator { get; set; }
	}
}
