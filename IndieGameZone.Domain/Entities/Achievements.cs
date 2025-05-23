namespace IndieGameZone.Domain.Entities
{
	public class Achievements
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;

		//Navigation properties
		public virtual ICollection<UserAchievements> UserAchievements { get; set; } = new List<UserAchievements>();
	}
}
