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
		public void Configure(EntityTypeBuilder<Users> builder)
		{
			builder.ToTable("Users");
			builder.Property(u => u.IsActive);
			builder.Property(u => u.JoinedDate);
			builder.Property(u => u.LastLogin);
			builder.Property(u => u.RefreshToken);
			builder.Property(u => u.RefreshTokenExpiryTime);
			builder.Property(u => u.LastUsernameChangedDate);

			builder.HasMany(u => u.UserAchievements)
				.WithOne(ua => ua.User)
				.HasForeignKey(ua => ua.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.Notifications)
				.WithOne(n => n.User)
				.HasForeignKey(n => n.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(u => u.Wallet)
				.WithOne(w => w.User)
				.HasForeignKey<Wallets>(w => w.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.Games)
				.WithOne(g => g.Developer)
				.HasForeignKey(g => g.DeveloperId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.Transactions)
				.WithOne(t => t.User)
				.HasForeignKey(t => t.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.PurchaseTransactions)
				.WithOne(t => t.PurchaseUser)
				.HasForeignKey(t => t.PurchaseUserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(u => u.UserProfile)
				.WithOne(up => up.User)
				.HasForeignKey<UserProfiles>(up => up.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.Posts)
				.WithOne(p => p.User)
				.HasForeignKey(p => p.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.PostReactions)
				.WithOne(pr => pr.User)
				.HasForeignKey(pr => pr.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.PostComments)
				.WithOne(pc => pc.User)
				.HasForeignKey(pc => pc.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.ReportingUsers)
				.WithOne(r => r.ReportingUser)
				.HasForeignKey(r => r.ReportingUserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.Followers)
				.WithOne(f => f.Follower)
				.HasForeignKey(f => f.FollowerId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.Followees)
				.WithOne(f => f.Followee)
				.HasForeignKey(f => f.FolloweeId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.GameRecommendations)
				.WithOne(gr => gr.User)
				.HasForeignKey(gr => gr.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.WithdrawRequests)
				.WithOne(wr => wr.User)
				.HasForeignKey(wr => wr.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(u => u.Orders)
				.WithOne(o => o.User)
				.HasForeignKey(o => o.UserId)
				.OnDelete(DeleteBehavior.Restrict);


			var admin = new Users
			{
				Id = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"),
				UserName = "admin",
				NormalizedUserName = "ADMIN",
				Email = "admin@gmail.com",
				NormalizedEmail = "ADMIN@GMAIL.COM",
				EmailConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString(),
				ConcurrencyStamp = Guid.NewGuid().ToString(),
				PhoneNumberConfirmed = false,
				TwoFactorEnabled = false,
				LockoutEnabled = true,
				AccessFailedCount = 0,
				IsActive = true,
				JoinedDate = DateTime.Now
			};
			admin.PasswordHash = passwordHasher.HashPassword(admin, "admin");

			var moderator = new Users
			{
				Id = Guid.Parse("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
				UserName = "moderator",
				NormalizedUserName = "MODERATOR",
				Email = "moderator@gmail.com",
				NormalizedEmail = "MODERATOR@GMAIL.COM",
				EmailConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString(),
				ConcurrencyStamp = Guid.NewGuid().ToString(),
				PhoneNumberConfirmed = false,
				TwoFactorEnabled = false,
				LockoutEnabled = true,
				AccessFailedCount = 0,
				IsActive = true,
				JoinedDate = DateTime.Now
			};
			moderator.PasswordHash = passwordHasher.HashPassword(moderator, "moderator");

			var player1 = new Users
			{
				Id = Guid.Parse("23879117-e09e-40f1-b78f-1493d81baf49"),
				UserName = "player1",
				NormalizedUserName = "PLAYER1",
				Email = "player1@gmail.com",
				NormalizedEmail = "PLAYER1@GMAIL.COM",
				EmailConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString(),
				ConcurrencyStamp = Guid.NewGuid().ToString(),
				PhoneNumberConfirmed = false,
				TwoFactorEnabled = false,
				LockoutEnabled = true,
				AccessFailedCount = 0,
				IsActive = true,
				JoinedDate = DateTime.Now
			};
			player1.PasswordHash = passwordHasher.HashPassword(player1, "player1");

			var player2 = new Users
			{
				Id = Guid.Parse("91b106fa-7b95-480f-a12a-0e0303454332"),
				UserName = "player2",
				NormalizedUserName = "PLAYER2",
				Email = "player2@gmail.com",
				NormalizedEmail = "PLAYER2@GMAIL.COM",
				EmailConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString(),
				ConcurrencyStamp = Guid.NewGuid().ToString(),
				PhoneNumberConfirmed = false,
				TwoFactorEnabled = false,
				LockoutEnabled = true,
				AccessFailedCount = 0,
				IsActive = true,
				JoinedDate = DateTime.Now
			};
			player2.PasswordHash = passwordHasher.HashPassword(player2, "player2");

			var player3 = new Users
			{
				Id = Guid.Parse("537f05fd-120c-40b0-b2ec-639756f866ab"),
				UserName = "player3",
				NormalizedUserName = "PLAYER3",
				Email = "player3@gmail.com",
				NormalizedEmail = "PLAYER3@GMAIL.COM",
				EmailConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString(),
				ConcurrencyStamp = Guid.NewGuid().ToString(),
				PhoneNumberConfirmed = false,
				TwoFactorEnabled = false,
				LockoutEnabled = true,
				AccessFailedCount = 0,
				IsActive = true,
				JoinedDate = DateTime.Now
			};
			player3.PasswordHash = passwordHasher.HashPassword(player3, "player3");

			var developer1 = new Users
			{
				Id = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				UserName = "developer1",
				NormalizedUserName = "DEVELOPER1",
				Email = "developer1@gmail.com",
				NormalizedEmail = "DEVELOPER1@GMAIL.COM",
				EmailConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString(),
				ConcurrencyStamp = Guid.NewGuid().ToString(),
				PhoneNumberConfirmed = false,
				TwoFactorEnabled = false,
				LockoutEnabled = true,
				AccessFailedCount = 0,
				IsActive = true,
				JoinedDate = DateTime.Now
			};
			developer1.PasswordHash = passwordHasher.HashPassword(developer1, "developer1");

			var developer2 = new Users
			{
				Id = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				UserName = "developer2",
				NormalizedUserName = "DEVELOPER2",
				Email = "developer2@gmail.com",
				NormalizedEmail = "DEVELOPER2@GMAIL.COM",
				EmailConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString(),
				ConcurrencyStamp = Guid.NewGuid().ToString(),
				PhoneNumberConfirmed = false,
				TwoFactorEnabled = false,
				LockoutEnabled = true,
				AccessFailedCount = 0,
				IsActive = true,
				JoinedDate = DateTime.Now
			};
			developer2.PasswordHash = passwordHasher.HashPassword(developer2, "developer2");

			var developer3 = new Users
			{
				Id = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				UserName = "developer3",
				NormalizedUserName = "DEVELOPER3",
				Email = "developer3@gmail.com",
				NormalizedEmail = "DEVELOPER3@GMAIL.COM",
				EmailConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString(),
				ConcurrencyStamp = Guid.NewGuid().ToString(),
				PhoneNumberConfirmed = false,
				TwoFactorEnabled = false,
				LockoutEnabled = true,
				AccessFailedCount = 0,
				IsActive = true,
				JoinedDate = DateTime.Now
			};
			developer3.PasswordHash = passwordHasher.HashPassword(developer3, "developer3");



			builder.HasData(admin, moderator, player1, player2, player3, developer1, developer2, developer3);
		}
	}
}
