namespace IndieGameZone.Domain.Entities
{
	public class Posts
	{
		public Guid Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Content { get; set; } = string.Empty;
		public string Image { get; set; } = string.Empty;
		public bool IsCensoredByAI { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? CensoredAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public bool IsActive { get; set; }
		public Guid UserId { get; set; }
		public Guid GameId { get; set; }

		//Navigation properties
		public virtual Users User { get; set; } = null!;
		public virtual Games Game { get; set; } = null!;
		public virtual ICollection<PostReactions> PostReactions { get; set; } = new List<PostReactions>();
		public virtual ICollection<PostComments> PostComments { get; set; } = new List<PostComments>();
		public virtual ICollection<PostTags> PostTags { get; set; } = new List<PostTags>();
		public virtual ICollection<Reports> Reports { get; set; } = new List<Reports>();
	}
}
