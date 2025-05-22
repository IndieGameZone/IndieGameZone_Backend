using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GameConfiguration : IEntityTypeConfiguration<Games>
	{
		public void Configure(EntityTypeBuilder<Games> builder)
		{
			builder.HasKey(g => g.Id);
			builder.Property(g => g.Name).HasMaxLength(100);
			builder.Property(g => g.CoverImage);
			builder.Property(g => g.VideoLink);
			builder.Property(g => g.IsActive);
			builder.Property(g => g.Price);
			builder.Property(g => g.ReleasedDate);
			builder.Property(g => g.UpdatedAt);
			builder.Property(g => g.AverageSession);

			builder.HasMany(g => g.Languages)
				.WithMany(l => l.Games)
				.UsingEntity<GameLanguages>();
			builder.HasMany(g => g.Tags)
				.WithMany(t => t.Games)
				.UsingEntity<GameTags>();
			builder.HasOne(g => g.Category)
				.WithMany(c => c.Games)
				.HasForeignKey(g => g.CategoryId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(g => g.Platforms)
				.WithMany(p => p.Games)
				.UsingEntity<GamePlatforms>();
			builder.HasMany(g => g.GameInfos)
				.WithOne(gi => gi.Games)
				.HasForeignKey(gi => gi.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(g => g.AgeRestriction)
				.WithMany(ar => ar.Games)
				.HasForeignKey(g => g.AgeRestrictionId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(g => g.Developers)
				.WithMany(d => d.Games)
				.HasForeignKey(g => g.DeveloperId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(g => g.Reviews)
				.WithOne(r => r.Game)
				.HasForeignKey(r => r.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(g => g.Discounts)
				.WithOne(d => d.Game)
				.HasForeignKey(d => d.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(g => g.CommercialRegistration)
				.WithOne(cr => cr.Game)
				.HasForeignKey(cr => cr.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(g => g.Wishlists)
				.WithOne(w => w.Game)
				.HasForeignKey(w => w.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(g => g.Libraries)
				.WithOne(l => l.Game)
				.HasForeignKey(l => l.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(g => g.Posts)
				.WithOne(p => p.Game)
				.HasForeignKey(p => p.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(g => g.Reports)
				.WithOne(r => r.Game)
				.HasForeignKey(r => r.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(g => g.GameRecommendations)
				.WithOne(gr => gr.Game)
				.HasForeignKey(gr => gr.GameId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
