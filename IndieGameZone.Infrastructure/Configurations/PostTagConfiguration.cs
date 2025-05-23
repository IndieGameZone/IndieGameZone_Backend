using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class PostTagConfiguration : IEntityTypeConfiguration<PostTags>
	{
		public void Configure(EntityTypeBuilder<PostTags> builder)
		{
			builder.HasKey(pt => new { pt.PostId, pt.TagId });

			builder.HasOne(pt => pt.Post)
				.WithMany(p => p.PostTags)
				.HasForeignKey(pt => pt.PostId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(pt => pt.Tag)
				.WithMany(t => t.PostTags)
				.HasForeignKey(pt => pt.TagId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
