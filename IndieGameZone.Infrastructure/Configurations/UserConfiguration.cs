using IndieGameZone.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<Users>
	{
		private readonly IPasswordHasher<Users> passwordHasher;

		public UserConfiguration(IPasswordHasher<Users> passwordHasher)
		{
			this.passwordHasher = passwordHasher;
		}
		public async void Configure(EntityTypeBuilder<Users> builder)
		{
			builder.Property(u => u.IsActive);
			builder.Property(u => u.JoinedDate);
			builder.Property(u => u.LastLogin);
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

			var admin = new Users
			{
				Id = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"),
				Email = "admin@gmail.com",
				NormalizedEmail = "ADMIN@GMAIL.COM",
				EmailConfirmed = true,
				IsActive = true,
				JoinedDate = DateTime.Now,
			};
			admin.PasswordHash = passwordHasher.HashPassword(admin, "admin");

			var moderator = new Users
			{
				Id = Guid.Parse("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
				Email = "moderator@gmail.com",
				NormalizedEmail = "MODERATOR@GMAIL.COM",
				EmailConfirmed = true,
				IsActive = true,
				JoinedDate = DateTime.Now,
			};
			moderator.PasswordHash = passwordHasher.HashPassword(moderator, "moderator");

			var developer = new Users
			{
				Id = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				Email = "developer@gmail.com",
				NormalizedEmail = "DEVELOPER@GMAIL.COM",
				EmailConfirmed = true,
				IsActive = true
			};
			developer.PasswordHash = passwordHasher.HashPassword(developer, "developer");

			var player = new Users
			{
				Id = Guid.Parse("23879117-e09e-40f1-b78f-1493d81baf49"),
				Email = "player@gmail.com",
				NormalizedEmail = "PLAYER@GMAIL.COM",
				EmailConfirmed = true,
				IsActive = true
			};
			player.PasswordHash = passwordHasher.HashPassword(player, "player");

			builder.HasData(admin, moderator, developer, player);
		}
	}
}
