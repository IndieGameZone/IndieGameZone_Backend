using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GameStatusConfiguration : IEntityTypeConfiguration<GameStatuses>
	{
		public void Configure(EntityTypeBuilder<GameStatuses> builder)
		{
			builder.HasKey(builder => builder.Id);
			builder.Property(builder => builder.Name).HasMaxLength(10);

			builder.HasMany(builder => builder.Games)
				.WithOne(builder => builder.GameStatus)
				.HasForeignKey(builder => builder.GameStatusId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				new GameStatuses
				{
					Id = Guid.Parse("92f9b646-d1db-4bd1-93ed-e5dc73ccd37e"),
					Name = "Paid"
				},
				new GameStatuses
				{
					Id = Guid.Parse("5fde9b6a-ddda-4833-a744-7fbb4d8efb3f"),
					Name = "Free"
				},
				new GameStatuses
				{
					Id = Guid.Parse("8097fd8b-f4ad-4fb9-93f3-6f8598cf6a4f"),
					Name = "Alpha"
				},
				new GameStatuses
				{
					Id = Guid.Parse("5fef12e9-ad13-4707-ae74-7ecc23a43d5b"),
					Name = "Demo"
				}
			);
		}
	}
}
