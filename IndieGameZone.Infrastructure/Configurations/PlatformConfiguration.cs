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

			builder.HasData(
				new Platforms { Id = Guid.Parse("574cb883-e637-4f18-9518-269e4d22312c"), Name = "MacOS" },
				new Platforms { Id = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), Name = "Windows" },
				new Platforms { Id = Guid.Parse("db498cbb-c76f-4166-9836-8ecb462419e6"), Name = "Linux" }
			);
		}
	}
}
