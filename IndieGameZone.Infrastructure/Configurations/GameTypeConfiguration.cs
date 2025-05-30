using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GameTypeConfiguration : IEntityTypeConfiguration<GameTypes>
	{
		public void Configure(EntityTypeBuilder<GameTypes> builder)
		{
			builder.HasKey(builder => builder.Id);
			builder.Property(builder => builder.Name).HasMaxLength(10);

			builder.HasMany(builder => builder.Games)
				.WithOne(builder => builder.GameTypes)
				.HasForeignKey(builder => builder.GameTypeId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				new GameTypes
				{
					Id = Guid.Parse("92f9b646-d1db-4bd1-93ed-e5dc73ccd37e"),
					Name = "Paid"
				},
				new GameTypes
				{
					Id = Guid.Parse("5fde9b6a-ddda-4833-a744-7fbb4d8efb3f"),
					Name = "Free"
				}
			);
		}
	}
}
