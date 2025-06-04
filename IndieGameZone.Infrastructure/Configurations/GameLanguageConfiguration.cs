using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GameLanguageConfiguration : IEntityTypeConfiguration<GameLanguages>
	{
		public void Configure(EntityTypeBuilder<GameLanguages> builder)
		{
			builder.HasKey(gl => new { gl.GameId, gl.LanguageId });
			builder.HasOne(gl => gl.Game)
				.WithMany(g => g.GameLanguages)
				.HasForeignKey(gl => gl.GameId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(gl => gl.Language)
				.WithMany(l => l.GameLanguages)
				.HasForeignKey(gl => gl.LanguageId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				// The Deadseat
				new GameLanguages
				{
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				// MidnightShift
				new GameLanguages
				{
					GameId = Guid.Parse("5763f752-914c-4436-803f-4410118774a3"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				// Broken Relic
				new GameLanguages
				{
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				//Moldwasher
				new GameLanguages
				{
					GameId = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				// Latestop
				new GameLanguages
				{
					GameId = Guid.Parse("0f78b4ed-b351-4517-89fc-a05f07570e44"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				// QuietPlace
				new GameLanguages
				{
					GameId = Guid.Parse("381c9309-d036-4c9a-a651-d8ebf631528e"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				// Pacside
				new GameLanguages
				{
					GameId = Guid.Parse("f6935d98-bd02-4716-a968-3bc870e6233b"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				// Sheepy
				new GameLanguages
				{
					GameId = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				// Daughter
				new GameLanguages
				{
					GameId = Guid.Parse("a670e609-db94-42b5-b196-f618e79ce15b"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				// Missing
				new GameLanguages
				{
					GameId = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				//Bloodmall
				new GameLanguages
				{
					GameId = Guid.Parse("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				//Thunderhead
				new GameLanguages
				{
					GameId = Guid.Parse("34209460-1478-4545-9f15-723eeefc5697"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				//Evaluation
				new GameLanguages
				{
					GameId = Guid.Parse("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				//Dominoid
				new GameLanguages
				{
					GameId = Guid.Parse("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},

				//DiggingHour
				new GameLanguages
				{
					GameId = Guid.Parse("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				}
			);
		}
	}
}
