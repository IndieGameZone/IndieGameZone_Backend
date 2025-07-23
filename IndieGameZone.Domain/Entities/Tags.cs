using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.Entities
{
	public class Tags
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public TagTypeEnum Type { get; set; }
		public bool IsDeleted { get; set; }

		// Navigation property
		public ICollection<GameTags> GameTags { get; set; } = new List<GameTags>();
		public ICollection<PostTags> PostTags { get; set; } = new List<PostTags>();
	}
}
