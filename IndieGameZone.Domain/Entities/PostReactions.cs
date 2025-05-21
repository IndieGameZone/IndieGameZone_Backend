namespace IndieGameZone.Domain.Entities
{
	public class PostReactions
	{
		public Guid UserId { get; set; }
		public Guid PostId { get; set; }

		//Navigation properties
		public virtual Users User { get; set; } = null!;
		public virtual Posts Post { get; set; } = null!;
	}
}
