using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class PostConfiguration : IEntityTypeConfiguration<Posts>
	{
		public void Configure(EntityTypeBuilder<Posts> builder)
		{
			builder.HasKey(p => p.Id);
			builder.Property(p => p.Title).HasMaxLength(150);
			builder.Property(p => p.Content);
			builder.Property(p => p.CreatedAt);
			builder.Property(p => p.CensoredAt);
			builder.Property(p => p.UpdatedAt);
			builder.Property(p => p.Status);

			builder.HasOne(p => p.User)
				.WithMany(u => u.Posts)
				.HasForeignKey(p => p.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(p => p.Game)
				.WithMany(g => g.Posts)
				.HasForeignKey(p => p.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(p => p.PostReactions)
				.WithOne(pr => pr.Post)
				.HasForeignKey(pr => pr.PostId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(p => p.PostComments)
				.WithOne(pc => pc.Post)
				.HasForeignKey(pc => pc.PostId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(pt => pt.PostTags)
				.WithOne(pt => pt.Post)
				.HasForeignKey(pt => pt.PostId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
