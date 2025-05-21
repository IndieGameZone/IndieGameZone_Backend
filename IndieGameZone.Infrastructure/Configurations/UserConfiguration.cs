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
		}
	}
}
