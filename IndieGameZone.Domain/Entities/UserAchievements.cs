namespace IndieGameZone.Domain.Entities
{
	public class UserAchievements
	{
		public Guid UserId { get; set; }
		public Guid AchievementId { get; set; }

		// Navigation properties
		public Users User { get; set; }
		public Achievements Achievement { get; set; }
	}
}
