using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class TagConfiguration : IEntityTypeConfiguration<Tags>
	{
		public void Configure(EntityTypeBuilder<Tags> builder)
		{
			builder.HasKey(t => t.Id);
			builder.Property(t => t.Name).HasMaxLength(100);

			builder.HasMany(t => t.Games)
				.WithMany(g => g.Tags)
				.UsingEntity<GameTags>();
			builder.HasMany(t => t.Posts)
				.WithMany(p => p.Tags)
				.UsingEntity<PostTags>();
		}
	}
}
