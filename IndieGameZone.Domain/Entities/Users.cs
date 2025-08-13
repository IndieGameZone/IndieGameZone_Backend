using Microsoft.AspNetCore.Identity;

namespace IndieGameZone.Domain.Entities
{
	public class Users : IdentityUser<Guid>
	{
		public bool IsActive { get; set; }
		public DateTime JoinedDate { get; set; }
		public DateTime? LastLogin { get; set; }
		public string? RefreshToken { get; set; }
		public DateTime? RefreshTokenExpiryTime { get; set; }
		public DateTime? LastUsernameChangedDate { get; set; }

		//Navigation Properties
		public virtual Wallets Wallet { get; set; } = null!;
		public virtual ICollection<BanHistories> BansReceived { get; set; } = new List<BanHistories>();
		public virtual ICollection<BanHistories> BansPerformed { get; set; } = new List<BanHistories>();
		public virtual ICollection<UserAchievements> UserAchievements { get; set; } = new List<UserAchievements>();
		public virtual ICollection<Notifications> Notifications { get; set; } = null!;
		public virtual ICollection<Games> Games { get; set; } = null!;
		public virtual ICollection<Reviews> Reviews { get; set; } = new List<Reviews>();
		public virtual ICollection<Wishlists> Wishlists { get; set; } = new List<Wishlists>();
		public virtual ICollection<Libraries> Libraries { get; set; } = new List<Libraries>();
		public virtual ICollection<Transactions> PurchaseTransactions { get; set; } = new List<Transactions>();
		public virtual ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();
		public virtual UserProfiles UserProfile { get; set; } = null!;
		public virtual ICollection<Posts> Posts { get; set; } = new List<Posts>();
		public virtual ICollection<PostReactions> PostReactions { get; set; } = new List<PostReactions>();
		public virtual ICollection<PostComments> PostComments { get; set; } = new List<PostComments>();
		public virtual ICollection<Reports> ReportingUsers { get; set; } = new List<Reports>();
		public virtual ICollection<Reports> ReportedUsers { get; set; } = new List<Reports>();
		public virtual ICollection<UserFollows> Followers { get; set; } = new List<UserFollows>();
		public virtual ICollection<UserFollows> Followees { get; set; } = new List<UserFollows>();
		public virtual ICollection<GameRecommendations> GameRecommendations { get; set; } = new List<GameRecommendations>();
		public virtual ICollection<GameCensorLogs> GameCensorLogs { get; set; } = new List<GameCensorLogs>();
		public virtual ICollection<DownloadSlots> DownloadSlots { get; set; } = new List<DownloadSlots>();
		public virtual ICollection<WithdrawRequests> WithdrawRequests { get; set; } = new List<WithdrawRequests>();
		public virtual ICollection<Orders> Orders { get; set; } = new List<Orders>();

	}
}
