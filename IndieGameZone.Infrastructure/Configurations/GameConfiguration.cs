using IndieGameZone.Domain.Constants;
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
			builder.Property(g => g.AllowDonation);
			builder.Property(g => g.Status);
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
					Status = GameStatus.Approved,
					Price = 100000,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("7a03afa3-2635-43bd-a58c-daeb80d3cef7"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("5763f752-914c-4436-803f-4410118774a3"),
					Name = "MidnightShift",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftCoverImage.png",
					VideoLink = "https://www.youtube.com/watch?v=v1oeNEKiwTg",
					Status = GameStatus.Approved,
					Price = 150000,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = true,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					Name = "Broken Relic",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelicCoverImage.png",
					VideoLink = "https://www.youtube.com/watch?v=ColSNi0XD6Q",
					Status = GameStatus.Approved,
					Price = 200000,
					CreatedAt = DateTime.Now,
					AverageSession = 3.0,
					AllowDonation = false,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				},
				new Games
				{
					Id = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1"),
					Name = "Moldwasher",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/MoldwasherCoverImage.png",
					VideoLink = "https://www.youtube.com/watch?v=6KGgPoY7TbY",
					Status = GameStatus.Approved,
					Price = 120000,
					CreatedAt = DateTime.Now,
					AverageSession = 1.0,
					AllowDonation = true,
					CategoryId = Guid.Parse("7a03afa3-2635-43bd-a58c-daeb80d3cef7"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("0f78b4ed-b351-4517-89fc-a05f07570e44"),
					Name = "Latestop",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/MoldwasherCoverImage.png",
					VideoLink = "https://www.youtube.com/watch?v=WJKp2xT4QTs",
					Status = GameStatus.Approved,
					Price = 100000,
					CreatedAt = DateTime.Now,
					AverageSession = 1.0,
					AllowDonation = false,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("381c9309-d036-4c9a-a651-d8ebf631528e"),
					Name = "QuietPlace",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage.png",
					VideoLink = "https://www.youtube.com/watch?v=gjV5Vdf04UY&t=1s",
					Status = GameStatus.Approved,
					Price = 50000,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = true,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				},
				new Games
				{
					Id = Guid.Parse("f6935d98-bd02-4716-a968-3bc870e6233b"),
					Name = "Pacside",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage.png",
					VideoLink = "https://www.youtube.com/watch?v=yxt7w5VRQ_w",
					Status = GameStatus.Approved,
					Price = 75000,
					CreatedAt = DateTime.Now,
					AverageSession = 1.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("7a03afa3-2635-43bd-a58c-daeb80d3cef7"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
					Name = "Sheepy",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage.jpg",
					VideoLink = "https://www.youtube.com/watch?v=RRs_AI96h-w",
					Status = GameStatus.Approved,
					Price = 75000,
					CreatedAt = DateTime.Now,
					AverageSession = 1.5,
					AllowDonation = true,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("a670e609-db94-42b5-b196-f618e79ce15b"),
					Name = "Daughter",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage.png",
					VideoLink = "",
					Status = GameStatus.Approved,
					Price = 75000,
					CreatedAt = DateTime.Now,
					AverageSession = 1,
					AllowDonation = false,
					CategoryId = Guid.Parse("2d740ce2-a803-4b32-8df8-ab5139203742"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				},
				new Games
				{
					Id = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31"),
					Name = "Missing",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage.png",
					VideoLink = "",
					Status = GameStatus.Approved,
					Price = 60000,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = true,
					CategoryId = Guid.Parse("77c89b32-78e3-4fea-915f-4b8df819ffa2"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
					Name = "Bloodmall",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage.png",
					VideoLink = "https://www.youtube.com/watch?v=1fYf3Rt7guw",
					Status = GameStatus.Approved,
					Price = 80000,
					CreatedAt = DateTime.Now,
					AverageSession = 2.0,
					AllowDonation = true,
					CategoryId = Guid.Parse("7a03afa3-2635-43bd-a58c-daeb80d3cef7"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("34209460-1478-4545-9f15-723eeefc5697"),
					Name = "Thunderhead",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage.png",
					VideoLink = "https://www.youtube.com/watch?v=c8JdCXw4l3k",
					Status = GameStatus.Approved,
					Price = 90000,
					CreatedAt = DateTime.Now,
					AverageSession = 1.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				},
				new Games
				{
					Id = Guid.Parse("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
					Name = "Evaluation",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage.png",
					VideoLink = "",
					Status = GameStatus.Approved,
					Price = 90000,
					CreatedAt = DateTime.Now,
					AverageSession = 1.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("77c89b32-78e3-4fea-915f-4b8df819ffa2"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
					Name = "Dominoid",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage.png",
					VideoLink = "",
					Status = GameStatus.Approved,
					Price = 95000,
					CreatedAt = DateTime.Now,
					AverageSession = 1.0,
					AllowDonation = true,
					CategoryId = Guid.Parse("bca8721b-c323-44a1-afcf-876e206ab035"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
					Name = "DiggingHour",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage.png",
					VideoLink = "https://www.youtube.com/watch?v=tNoPejgMaB0",
					Status = GameStatus.Approved,
					Price = 85000,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("2d740ce2-a803-4b32-8df8-ab5139203742"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				}
			);
		}
	}
}
