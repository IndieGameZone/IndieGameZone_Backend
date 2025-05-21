using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class UserFollowConfiguration : IEntityTypeConfiguration<UserFollows>
	{
		public void Configure(EntityTypeBuilder<UserFollows> builder)
		{
			builder.HasKey(uf => new { uf.FollowerId, uf.FollowedId });
			builder.Property(uf => uf.FollowedAt);

			builder.HasOne(uf => uf.Follower)
				.WithMany(u => u.Followers)
				.HasForeignKey(uf => uf.FollowerId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(uf => uf.Followed)
				.WithMany(u => u.Followeds)
				.HasForeignKey(uf => uf.FollowedId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
