using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Categories>
	{
		public void Configure(EntityTypeBuilder<Categories> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Name).HasMaxLength(100);

			builder.HasMany(c => c.Games)
				.WithMany(g => g.Categories)
				.UsingEntity<GameCategories>();
		}
	}
}
