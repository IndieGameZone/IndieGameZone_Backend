namespace IndieGameZone.Domain.Entities
{
	public class UserFollows
	{
		public Guid FollowingUserId { get; set; }
		public Guid FollowedUserId { get; set; }
		public DateTime FollowedAt { get; set; }

		// Navigation properties
		public virtual Users FollowingUser { get; set; } = null!;
		public virtual Users FollowedUser { get; set; } = null!;
	}
}
