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
			builder.Property(p => p.Image);
			builder.Property(p => p.CreatedAt);
			builder.Property(p => p.UpdatedAt);
			builder.Property(p => p.IsActive);

			builder.HasOne(p => p.User)
				.WithMany(u => u.Posts)
				.HasForeignKey(p => p.UserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(p => p.Game)
				.WithMany(g => g.Posts)
				.HasForeignKey(p => p.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(p => p.PostReactions)
				.WithOne(pr => pr.Post)
				.HasForeignKey(pr => pr.PostId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(p => p.PostComments)
				.WithOne(pc => pc.Post)
				.HasForeignKey(pc => pc.PostId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(p => p.Tags)
				.WithMany(t => t.Posts)
				.UsingEntity<PostTags>();
		}
	}
}
