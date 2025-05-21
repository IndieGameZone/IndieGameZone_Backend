using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GameInfoConfiguration : IEntityTypeConfiguration<GameInfos>
	{
		public void Configure(EntityTypeBuilder<GameInfos> builder)
		{
			builder.HasKey(g => g.Id);
			builder.Property(g => g.Image);
			builder.Property(g => g.Title).HasMaxLength(100);
			builder.Property(g => g.Description);

			builder.HasOne(g => g.Games)
				.WithMany(g => g.GameInfos)
				.HasForeignKey(g => g.GameId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
