using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class PlatformConfiguration : IEntityTypeConfiguration<Platforms>
	{
		public void Configure(EntityTypeBuilder<Platforms> builder)
		{
			builder.HasKey(p => p.Id);
			builder.Property(p => p.Name).HasMaxLength(100);

			builder.HasMany(p => p.Games)
				.WithMany(g => g.Platforms)
				.UsingEntity<GamePlatforms>();
		}
	}
}
