using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GamePriceLogConfiguration : IEntityTypeConfiguration<GamePriceLogs>
	{
		public void Configure(EntityTypeBuilder<GamePriceLogs> builder)
		{
			builder.HasKey(gpl => gpl.Id);
			builder.Property(gpl => gpl.Price);
			builder.Property(gpl => gpl.CreatedAt);

			builder.HasOne(gpl => gpl.Game)
				.WithMany(g => g.GamePriceLogs)
				.HasForeignKey(gpl => gpl.GameId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
