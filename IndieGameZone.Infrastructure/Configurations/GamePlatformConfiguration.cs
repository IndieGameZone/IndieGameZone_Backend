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
				// The Deadseat
				new GamePlatforms
				{
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip"
				},

				// MidnightShift
				new GamePlatforms
				{
					GameId = Guid.Parse("5763f752-914c-4436-803f-4410118774a3"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip"
				},

				// Broken Relic
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

				// Moldwasher
				new GamePlatforms
				{
					GameId = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip"
				},

				// Latestop
				new GamePlatforms
				{
					GameId = Guid.Parse("0f78b4ed-b351-4517-89fc-a05f07570e44"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip"
				},

				// QuietPlace
				new GamePlatforms
				{
					GameId = Guid.Parse("381c9309-d036-4c9a-a651-d8ebf631528e"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar"
				},

				// Pacside
				new GamePlatforms
				{
					GameId = Guid.Parse("f6935d98-bd02-4716-a968-3bc870e6233b"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar"
				},

				// Sheepy
				new GamePlatforms
				{
					GameId = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip"
				},

				// Daughter
				new GamePlatforms
				{
					GameId = Guid.Parse("a670e609-db94-42b5-b196-f618e79ce15b"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip"
				},

				// Missing
				new GamePlatforms
				{
					GameId = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip"
				},
				new GamePlatforms
				{
					GameId = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31"),
					PlatformId = Guid.Parse("574cb883-e637-4f18-9518-269e4d22312c"),
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip"
				}
			);
		}
	}
}
