namespace IndieGameZone.Domain.Entities
{
	public class PostComments
	{
		public Guid Id { get; set; }
		public string Content { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public bool IsActive { get; set; }
		public Guid PostId { get; set; }
		public Guid UserId { get; set; }

		// Navigation properties
		public virtual Posts Post { get; set; } = null!;
		public virtual Users User { get; set; } = null!;
		public virtual ICollection<Reports> Reports { get; set; } = new List<Reports>();
	}
}
