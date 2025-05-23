namespace IndieGameZone.Domain.Entities
{
	public class PostTags
	{
		public Guid PostId { get; set; }
		public Guid TagId { get; set; }

		// Navigation properties
		public Posts Post { get; set; } = null!;
		public Tags Tag { get; set; } = null!;
	}
}
