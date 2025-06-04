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

				// The Deadseat
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

				// Midnight Shift
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

				// Broken Relic
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

				// Moldwasher
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
				},

				// Latestop
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png",
					GameId = Guid.Parse("0f78b4ed-b351-4517-89fc-a05f07570e44")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png",
					GameId = Guid.Parse("0f78b4ed-b351-4517-89fc-a05f07570e44")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png",
					GameId = Guid.Parse("0f78b4ed-b351-4517-89fc-a05f07570e44")
				},

				// QuietPlace
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png",
					GameId = Guid.Parse("381c9309-d036-4c9a-a651-d8ebf631528e")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png",
					GameId = Guid.Parse("381c9309-d036-4c9a-a651-d8ebf631528e")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png",
					GameId = Guid.Parse("381c9309-d036-4c9a-a651-d8ebf631528e")
				},

				// Pacside
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png",
					GameId = Guid.Parse("f6935d98-bd02-4716-a968-3bc870e6233b")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png",
					GameId = Guid.Parse("f6935d98-bd02-4716-a968-3bc870e6233b")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png",
					GameId = Guid.Parse("f6935d98-bd02-4716-a968-3bc870e6233b")
				},

				// Sheepy
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg",
					GameId = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg",
					GameId = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg",
					GameId = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d")
				},

				// Daughter
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png",
					GameId = Guid.Parse("a670e609-db94-42b5-b196-f618e79ce15b")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png",
					GameId = Guid.Parse("a670e609-db94-42b5-b196-f618e79ce15b")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png",
					GameId = Guid.Parse("a670e609-db94-42b5-b196-f618e79ce15b")
				},

				// Missing
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png",
					GameId = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png",
					GameId = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png",
					GameId = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31")
				},

				// Bloodmall
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png",
					GameId = Guid.Parse("78b9e146-d318-4fc5-aa13-1ba2e7c304c9")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png",
					GameId = Guid.Parse("78b9e146-d318-4fc5-aa13-1ba2e7c304c9")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png",
					GameId = Guid.Parse("78b9e146-d318-4fc5-aa13-1ba2e7c304c9")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png",
					GameId = Guid.Parse("78b9e146-d318-4fc5-aa13-1ba2e7c304c9")
				},

				//Thunderhead
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png",
					GameId = Guid.Parse("34209460-1478-4545-9f15-723eeefc5697")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png",
					GameId = Guid.Parse("34209460-1478-4545-9f15-723eeefc5697")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png",
					GameId = Guid.Parse("34209460-1478-4545-9f15-723eeefc5697")
				},

				//Evaluation
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png",
					GameId = Guid.Parse("ae4dbda4-695a-44b8-9c93-7785cf1d717e")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png",
					GameId = Guid.Parse("ae4dbda4-695a-44b8-9c93-7785cf1d717e")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png",
					GameId = Guid.Parse("ae4dbda4-695a-44b8-9c93-7785cf1d717e")
				},

				//Dominoid
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png",
					GameId = Guid.Parse("ebe90f4b-241a-44d6-8645-4c1f28376f3e")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png",
					GameId = Guid.Parse("ebe90f4b-241a-44d6-8645-4c1f28376f3e")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png",
					GameId = Guid.Parse("ebe90f4b-241a-44d6-8645-4c1f28376f3e")
				},

				//DiggingHour
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png",
					GameId = Guid.Parse("85ce733a-7a1a-4e52-8513-2638b9c44e55")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png",
					GameId = Guid.Parse("85ce733a-7a1a-4e52-8513-2638b9c44e55")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png",
					GameId = Guid.Parse("85ce733a-7a1a-4e52-8513-2638b9c44e55")
				},

				//Dispatched
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png",
					GameId = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png",
					GameId = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png",
					GameId = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8")
				},

				//SecurityBooth
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png",
					GameId = Guid.Parse("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png",
					GameId = Guid.Parse("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png",
					GameId = Guid.Parse("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc")
				},

				//Atlyss
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png",
					GameId = Guid.Parse("152e3482-be53-44db-93e6-785823f6224e")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png",
					GameId = Guid.Parse("152e3482-be53-44db-93e6-785823f6224e")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png",
					GameId = Guid.Parse("152e3482-be53-44db-93e6-785823f6224e")
				},

				//Tomato
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png",
					GameId = Guid.Parse("d11cf96a-0d4f-4834-868c-59b32f047d2a")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png",
					GameId = Guid.Parse("d11cf96a-0d4f-4834-868c-59b32f047d2a")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png",
					GameId = Guid.Parse("d11cf96a-0d4f-4834-868c-59b32f047d2a")
				},

				//Leftovers
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png",
					GameId = Guid.Parse("ca5adbdb-160c-4a60-98b3-e4f464fbf904")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png",
					GameId = Guid.Parse("ca5adbdb-160c-4a60-98b3-e4f464fbf904")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png",
					GameId = Guid.Parse("ca5adbdb-160c-4a60-98b3-e4f464fbf904")
				},

				//TheStation
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png",
					GameId = Guid.Parse("791a4c74-d469-4432-bd76-c5ace021ce8e")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png",
					GameId = Guid.Parse("791a4c74-d469-4432-bd76-c5ace021ce8e")
				},
				new GameImages
				{
					Id = Guid.NewGuid(),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png",
					GameId = Guid.Parse("791a4c74-d469-4432-bd76-c5ace021ce8e")
				}
			);
		}
	}
}
