using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GamePlatformConfiguration : IEntityTypeConfiguration<GamePlatforms>
	{
		public void Configure(EntityTypeBuilder<GamePlatforms> builder)
		{
			builder.HasKey(gp => gp.Id);
			builder.Property(gp => gp.File);
			builder.Property(gp => gp.DisplayName).HasMaxLength(150);
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
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "TheDeadseat_Window.zip",
					Size = 179,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip"
				},

				// MidnightShift
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("5763f752-914c-4436-803f-4410118774a3"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "MidnightShift_Window.zip",
					Size = 84.6,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip"
				},

				// Broken Relic
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "BrokenRelic_Window.zip",
					Size = 99.3,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip"
				},
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					PlatformId = Guid.Parse("574cb883-e637-4f18-9518-269e4d22312c"),
					DisplayName = "BrokenRelic_Mac.zip",
					Size = 99.7,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip"
				},
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					PlatformId = Guid.Parse("db498cbb-c76f-4166-9836-8ecb462419e6"),
					DisplayName = "BrokenRelic_Linux.zip",
					Size = 100,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip"
				},

				// Moldwasher
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Moldwasher_Window.zip",
					Size = 31,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip"
				},

				// Latestop
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("0f78b4ed-b351-4517-89fc-a05f07570e44"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Latestop_Window.zip",
					Size = 87.6,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip"
				},

				// QuietPlace
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("381c9309-d036-4c9a-a651-d8ebf631528e"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "QuietPlace_Window.rar",
					Size = 58.6,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar"
				},

				// Pacside
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("f6935d98-bd02-4716-a968-3bc870e6233b"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Pacside_Window.rar",
					Size = 163,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar"
				},

				// Sheepy
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Sheepy_Window.zip",
					Size = 239,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip"
				},

				// Daughter
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("a670e609-db94-42b5-b196-f618e79ce15b"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Daughter_Window.zip",
					Size = 181,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip"
				},

				// Missing
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Missing_Window.zip",
					Size = 138,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip"
				},
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31"),
					PlatformId = Guid.Parse("574cb883-e637-4f18-9518-269e4d22312c"),
					DisplayName = "Missing_Mac.zip",
					Size = 246,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip"
				},

				//Bloddymall
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Bloddymall_Window.zip",
					Size = 93.8,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip"
				},
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
					PlatformId = Guid.Parse("db498cbb-c76f-4166-9836-8ecb462419e6"),
					DisplayName = "Bloddymall_Linux.zip",
					Size = 94.9,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip"
				},

				//Thunderhead
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("34209460-1478-4545-9f15-723eeefc5697"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Thunderhead_Window.zip",
					Size = 153,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip"
				},

				//Evaluation
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Evaluation_Window.zip",
					Size = 224,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip"
				},

				//Dominoid
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Dominoid_Window.zip",
					Size = 109,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip"
				},

				//DiggingHour
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "DiggingHour_Window.zip",
					Size = 48,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip"
				},

				//Dispatched
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Dispatched_Window.zip",
					Size = 585,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip"
				},

				//SecurityBooth
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "SecurityBooth_Window.zip",
					Size = 127,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip"
				},

				//Atlyss
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("152e3482-be53-44db-93e6-785823f6224e"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Atlyss_Window.zip",
					Size = 126,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip"
				},

				//Tomato
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Tomato_Window.exe",
					Size = 224,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe"
				},

				//Leftovers
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "Leftovers_Window.zip",
					Size = 33.8,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip"
				},

				//TheStation
				new GamePlatforms
				{
					Id = Guid.NewGuid(),
					GameId = Guid.Parse("791a4c74-d469-4432-bd76-c5ace021ce8e"),
					PlatformId = Guid.Parse("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"),
					DisplayName = "TheStation_Window.rar",
					Size = 102,
					File = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar"
				}
			);
		}
	}
}
