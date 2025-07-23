namespace IndieGameZone.Domain.Entities
{
	public class Platforms
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public bool IsDeleted { get; set; }

		//Navigation property
		public virtual ICollection<GamePlatforms> GamePlatforms { get; set; } = new List<GamePlatforms>();
	}
}
