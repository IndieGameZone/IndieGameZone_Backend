using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class LanguageConfiguration : IEntityTypeConfiguration<Languages>
	{
		public void Configure(EntityTypeBuilder<Languages> builder)
		{
			builder.HasKey(l => l.Id);
			builder.Property(l => l.Name).HasMaxLength(100);

			builder.HasMany(l => l.Games)
				.WithMany(g => g.Languages)
				.UsingEntity<GameLanguages>();
		}
	}
}
