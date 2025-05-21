namespace IndieGameZone.Domain.Entities
{
	public class UserFollows
	{
		public Guid FollowerId { get; set; }
		public Guid FollowedId { get; set; }
		public DateTime FollowedAt { get; set; }

		// Navigation properties
		public virtual Users Follower { get; set; } = null!;
		public virtual Users Followed { get; set; } = null!;
	}
}
