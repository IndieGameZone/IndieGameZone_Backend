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
			builder.HasMany(u => u.ReportingUsers)
				.WithOne(r => r.ReportingUser)
				.HasForeignKey(r => r.ReportingUserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.ReportedUsers)
				.WithOne(r => r.ReportedUser)
				.HasForeignKey(r => r.ReportedUserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.FollowingUsers)
				.WithOne(f => f.FollowingUser)
				.HasForeignKey(f => f.FollowingUserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.FollowedUsers)
				.WithOne(f => f.FollowedUser)
				.HasForeignKey(f => f.FollowedUserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(u => u.GameRecommendations)
				.WithOne(gr => gr.User)
				.HasForeignKey(gr => gr.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
