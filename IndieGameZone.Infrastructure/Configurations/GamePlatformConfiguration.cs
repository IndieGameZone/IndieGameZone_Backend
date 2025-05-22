using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GamePlatformConfiguration : IEntityTypeConfiguration<GamePlatforms>
	{
		public void Configure(EntityTypeBuilder<GamePlatforms> builder)
		{
			builder.HasKey(gp => new { gp.GameId, gp.PlatformId });
			builder.Property(gp => gp.File);
			builder.HasOne(gp => gp.Game)
				.WithMany(g => g.GamePlatforms)
				.HasForeignKey(gp => gp.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(gp => gp.Platform)
				.WithMany(p => p.GamePlatforms)
				.HasForeignKey(gp => gp.PlatformId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasData(
				new GamePlatforms
				{
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip"
				}
			);
		}
	}
}
