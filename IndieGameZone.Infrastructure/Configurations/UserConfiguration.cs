using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<Users>
	{
		public void Configure(EntityTypeBuilder<Users> builder)
		{
			builder.Property(u => u.IsActive);
			builder.Property(u => u.RefreshToken);
			builder.Property(u => u.RefreshTokenExpiryTime);

			builder.HasMany(u => u.BanHistories)
				.WithOne(b => b.User)
				.HasForeignKey(b => b.UserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.Achievements)
				.WithMany(a => a.Users)
				.UsingEntity<UserAchievements>();
			builder.HasMany(u => u.Notifications)
				.WithOne(n => n.User)
				.HasForeignKey(n => n.UserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(u => u.Wallet)
				.WithOne(w => w.User)
				.HasForeignKey<Wallets>(w => w.UserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.Games)
				.WithOne(g => g.Developers)
				.HasForeignKey(g => g.DeveloperId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.Coupons)
				.WithOne(c => c.User)
				.HasForeignKey(c => c.UserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.Transactions)
				.WithOne(t => t.User)
				.HasForeignKey(t => t.UserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(u => u.UserProfile)
				.WithOne(up => up.User)
				.HasForeignKey<UserProfiles>(up => up.UserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.Posts)
				.WithOne(p => p.User)
				.HasForeignKey(p => p.UserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.PostReactions)
				.WithOne(pr => pr.User)
				.HasForeignKey(pr => pr.UserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.PostComments)
				.WithOne(pc => pc.User)
				.HasForeignKey(pc => pc.UserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.Reports)
				.WithOne(r => r.UserReport)
				.HasForeignKey(r => r.UserReportId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.Reported)
				.WithOne(r => r.UserReported)
				.HasForeignKey(r => r.UserReportedId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.Followers)
				.WithOne(f => f.Follower)
				.HasForeignKey(f => f.FollowedId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.Followeds)
				.WithOne(f => f.Followed)
				.HasForeignKey(f => f.FollowerId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.GameRecommendations)
				.WithOne(gr => gr.User)
				.HasForeignKey(gr => gr.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
