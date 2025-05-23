using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class PostReactionConfiguration : IEntityTypeConfiguration<PostReactions>
	{
		public void Configure(EntityTypeBuilder<PostReactions> builder)
		{
			builder.HasKey(p => new { p.PostId, p.UserId });

			builder.HasOne(p => p.Post)
				.WithMany(p => p.PostReactions)
				.HasForeignKey(p => p.PostId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(p => p.User)
				.WithMany(p => p.PostReactions)
				.HasForeignKey(p => p.UserId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
