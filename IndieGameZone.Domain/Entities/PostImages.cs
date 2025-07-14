namespace IndieGameZone.Domain.Entities
{
	public class PostImages
	{
		public Guid Id { get; set; }
		public string Image { get; set; } = string.Empty;
		public Guid PostId { get; set; }

		// Navigation properties
		public virtual Posts Post { get; set; } = null!;
	}
}
