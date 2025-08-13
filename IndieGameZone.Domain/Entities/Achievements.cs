using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.Entities
{
	public class Achievements
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Image { get; set; } = string.Empty;
		public double ProgressLevel { get; set; }
		public AchievementType Type { get; set; }
		public bool IsDeleted { get; set; }

		//Navigation properties
		public virtual ICollection<UserAchievements> UserAchievements { get; set; } = new List<UserAchievements>();
	}
}
