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
				new GameLanguages
				{
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},
				new GameLanguages
				{
					GameId = Guid.Parse("5763f752-914c-4436-803f-4410118774a3"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},
				new GameLanguages
				{
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				},
				new GameLanguages
				{
					GameId = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1"),
					LanguageId = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527")
				}
			);
		}
	}
}
