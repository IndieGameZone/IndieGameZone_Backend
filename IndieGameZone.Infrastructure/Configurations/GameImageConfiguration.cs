using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GameImageConfiguration : IEntityTypeConfiguration<GameImages>
	{
		public void Configure(EntityTypeBuilder<GameImages> builder)
		{
			builder.HasKey(g => g.Id);
			builder.Property(g => g.Image);

			builder.HasOne(g => g.Games)
				.WithMany(g => g.GameImages)
				.HasForeignKey(g => g.GameId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasData(
				new GameImages
				{
					Id = Guid.Parse("2212b056-b7e1-4bd4-a258-aae3e24f9a87"),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage1.png",
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7")
				},
				new GameImages
				{
					Id = Guid.Parse("396cf491-b737-4983-a65e-42ecd36080d7"),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage2.png",
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7")
				},
				new GameImages
				{
					Id = Guid.Parse("dc5e81ec-24b6-4109-ba9f-e9de4ad9a855"),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage3.png",
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7")
				},
				new GameImages
				{
					Id = Guid.Parse("81738026-cd42-482c-a692-f080a6fe9240"),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage4.png",
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7")
				},
				new GameImages
				{
					Id = Guid.Parse("d3e36747-a19a-41ff-b8a1-1c274e378dab"),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage5.png",
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png",
					GameId = Guid.Parse("5763f752-914c-4436-803f-4410118774a3")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png",
					GameId = Guid.Parse("5763f752-914c-4436-803f-4410118774a3")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png",
					GameId = Guid.Parse("5763f752-914c-4436-803f-4410118774a3")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png",
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png",
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png",
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d")
				}, new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png",
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png",
					GameId = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png",
					GameId = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png",
					GameId = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1")
				}
			);
		}
	}
}
