using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GameRecommendationConfiguration : IEntityTypeConfiguration<GameRecommendations>
	{
		public void Configure(EntityTypeBuilder<GameRecommendations> builder)
		{
			builder.HasKey(g => new { g.GameId, g.UserId });

			builder.HasOne(g => g.Game)
				.WithMany(g => g.GameRecommendations)
				.HasForeignKey(g => g.GameId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(g => g.User)
				.WithMany(g => g.GameRecommendations)
				.HasForeignKey(g => g.UserId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
