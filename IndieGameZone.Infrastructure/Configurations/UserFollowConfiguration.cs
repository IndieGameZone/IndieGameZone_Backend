using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class UserFollowConfiguration : IEntityTypeConfiguration<UserFollows>
	{
		public void Configure(EntityTypeBuilder<UserFollows> builder)
		{
			builder.HasKey(uf => new { uf.FollowingUserId, uf.FollowedUserId });
			builder.Property(uf => uf.FollowedAt);

			builder.HasOne(uf => uf.FollowingUser)
				.WithMany(u => u.FollowingUsers)
				.HasForeignKey(uf => uf.FollowingUserId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(uf => uf.FollowedUser)
				.WithMany(u => u.FollowedUsers)
				.HasForeignKey(uf => uf.FollowedUserId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
