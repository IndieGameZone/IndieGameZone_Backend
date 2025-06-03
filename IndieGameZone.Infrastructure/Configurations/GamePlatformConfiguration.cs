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
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(gp => gp.Platform)
				.WithMany(p => p.GamePlatforms)
				.HasForeignKey(gp => gp.PlatformId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasData(
				new GamePlatforms
				{
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip"
				},
				new GamePlatforms
				{
					GameId = Guid.Parse("5763f752-914c-4436-803f-4410118774a3"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip"
				},
				new GamePlatforms
				{
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip"
				},
				new GamePlatforms
				{
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					PlatformId = Guid.Parse("574cb883-e637-4f18-9518-269e4d22312c"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip"
				},
				new GamePlatforms
				{
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					PlatformId = Guid.Parse("db498cbb-c76f-4166-9836-8ecb462419e6"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip"
				},
				new GamePlatforms
				{
					GameId = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip"
				}
			);
		}
	}
}
