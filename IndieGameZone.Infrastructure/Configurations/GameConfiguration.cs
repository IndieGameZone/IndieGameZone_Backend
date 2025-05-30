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
			builder.Property(g => g.Description);
			builder.Property(g => g.IsCensoredByAI);
			builder.Property(g => g.IsActive);
			builder.Property(g => g.Price);
			builder.Property(g => g.CreatedAt);
			builder.Property(g => g.CensoredAt);
			builder.Property(g => g.UpdatedAt);
			builder.Property(g => g.AverageSession);

			builder.HasMany(g => g.GameLanguages)
				.WithOne(gl => gl.Game)
				.HasForeignKey(gl => gl.GameId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasMany(g => g.GameTags)
				.WithOne(gt => gt.Game)
				.HasForeignKey(gt => gt.GameId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(g => g.Category)
				.WithMany(c => c.Games)
				.HasForeignKey(g => g.CategoryId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.GamePlatforms)
				.WithOne(gp => gp.Game)
				.HasForeignKey(gp => gp.GameId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasMany(g => g.GameImages)
				.WithOne(gi => gi.Games)
				.HasForeignKey(gi => gi.GameId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(g => g.AgeRestriction)
				.WithMany(ar => ar.Games)
				.HasForeignKey(g => g.AgeRestrictionId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(g => g.Developers)
				.WithMany(d => d.Games)
				.HasForeignKey(g => g.DeveloperId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Reviews)
				.WithOne(r => r.Game)
				.HasForeignKey(r => r.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Discounts)
				.WithOne(d => d.Game)
				.HasForeignKey(d => d.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.CommercialRegistration)
				.WithOne(cr => cr.Game)
				.HasForeignKey(cr => cr.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Wishlists)
				.WithOne(w => w.Game)
				.HasForeignKey(w => w.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Libraries)
				.WithOne(l => l.Game)
				.HasForeignKey(l => l.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Posts)
				.WithOne(p => p.Game)
				.HasForeignKey(p => p.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Reports)
				.WithOne(r => r.Game)
				.HasForeignKey(r => r.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.GameRecommendations)
				.WithOne(gr => gr.Game)
				.HasForeignKey(gr => gr.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(g => g.GameTypes)
				.WithMany(gs => gs.Games)
				.HasForeignKey(g => g.GameTypeId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Transactions)
				.WithOne(t => t.Game)
				.HasForeignKey(t => t.GameId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				new Games
				{
					Id = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					Name = "The Deadseat",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatCoverImage.png",
					VideoLink = "https://www.youtube.com/watch?v=Q4A2c8-BN78&t=2s",
					IsCensoredByAI = true,
					IsActive = true,
					Price = 100000,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					CategoryId = Guid.Parse("7a03afa3-2635-43bd-a58c-daeb80d3cef7"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
					GameTypeId = Guid.Parse("92f9b646-d1db-4bd1-93ed-e5dc73ccd37e"),
				}
			);
		}
	}
}
