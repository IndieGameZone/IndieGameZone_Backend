using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GameTagConfiguration : IEntityTypeConfiguration<GameTags>
	{
		public void Configure(EntityTypeBuilder<GameTags> builder)
		{
			builder.HasKey(gt => new { gt.GameId, gt.TagId });
			builder.HasOne(gt => gt.Game)
				.WithMany(g => g.GameTags)
				.HasForeignKey(gt => gt.GameId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(gt => gt.Tag)
				.WithMany(t => t.GameTags)
				.HasForeignKey(gt => gt.TagId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasData(
				//Deadseat
				new GameTags
				{
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					TagId = Guid.Parse("1c175c84-379e-43dc-a95a-aafd910d6a00")
				},
				new GameTags
				{
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					TagId = Guid.Parse("fcf4e928-dc77-405c-a13e-1d1d5e308d6b")
				},
				new GameTags
				{
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					TagId = Guid.Parse("3ef686ac-5e11-45d8-afab-223d2d149f6f")
				},
				new GameTags
				{
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					TagId = Guid.Parse("37223e27-41ad-44cb-9332-d985dbc9f708")
				},

				// MidnightShift
				new GameTags
				{
					GameId = Guid.Parse("5763f752-914c-4436-803f-4410118774a3"),
					TagId = Guid.Parse("3ef686ac-5e11-45d8-afab-223d2d149f6f")
				},
				new GameTags
				{
					GameId = Guid.Parse("5763f752-914c-4436-803f-4410118774a3"),
					TagId = Guid.Parse("ad95ed3f-284a-45d4-adc2-75b4f3681301")
				},
				new GameTags
				{
					GameId = Guid.Parse("5763f752-914c-4436-803f-4410118774a3"),
					TagId = Guid.Parse("e4e35307-2071-4a75-88fc-579db0077703")
				},

				// Broken Relic
				new GameTags
				{
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					TagId = Guid.Parse("37223e27-41ad-44cb-9332-d985dbc9f708")
				},
				new GameTags
				{
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					TagId = Guid.Parse("ad95ed3f-284a-45d4-adc2-75b4f3681301")
				},
				new GameTags
				{
					GameId = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					TagId = Guid.Parse("e4e35307-2071-4a75-88fc-579db0077703")
				},

				// Moldwasher
				new GameTags
				{
					GameId = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1"),
					TagId = Guid.Parse("37223e27-41ad-44cb-9332-d985dbc9f708")
				},
				new GameTags
				{
					GameId = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1"),
					TagId = Guid.Parse("8c13bf31-2b82-4452-9a5c-2968c01e1dac")
				},
				new GameTags
				{
					GameId = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1"),
					TagId = Guid.Parse("e4e35307-2071-4a75-88fc-579db0077703")
				},

				// Latestop
				new GameTags
				{
					GameId = Guid.Parse("0f78b4ed-b351-4517-89fc-a05f07570e44"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("0f78b4ed-b351-4517-89fc-a05f07570e44"),
					TagId = Guid.Parse("3ef686ac-5e11-45d8-afab-223d2d149f6f")
				},

				// QuietPlace
				new GameTags
				{
					GameId = Guid.Parse("381c9309-d036-4c9a-a651-d8ebf631528e"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("381c9309-d036-4c9a-a651-d8ebf631528e"),
					TagId = Guid.Parse("3ef686ac-5e11-45d8-afab-223d2d149f6f")
				},
				new GameTags
				{
					GameId = Guid.Parse("381c9309-d036-4c9a-a651-d8ebf631528e"),
					TagId = Guid.Parse("8c13bf31-2b82-4452-9a5c-2968c01e1dac")
				},

				// Pacside
				new GameTags
				{
					GameId = Guid.Parse("f6935d98-bd02-4716-a968-3bc870e6233b"),
					TagId = Guid.Parse("3ef686ac-5e11-45d8-afab-223d2d149f6f")
				},
				new GameTags
				{
					GameId = Guid.Parse("f6935d98-bd02-4716-a968-3bc870e6233b"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("f6935d98-bd02-4716-a968-3bc870e6233b"),
					TagId = Guid.Parse("ad95ed3f-284a-45d4-adc2-75b4f3681301")
				},

				// Sheepy
				new GameTags
				{
					GameId = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
					TagId = Guid.Parse("fcf4e928-dc77-405c-a13e-1d1d5e308d6b")
				},
				new GameTags
				{
					GameId = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
					TagId = Guid.Parse("ad95ed3f-284a-45d4-adc2-75b4f3681301")
				},
				new GameTags
				{
					GameId = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
					TagId = Guid.Parse("37223e27-41ad-44cb-9332-d985dbc9f708")
				},

				// Daughter
				new GameTags
				{
					GameId = Guid.Parse("a670e609-db94-42b5-b196-f618e79ce15b"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("a670e609-db94-42b5-b196-f618e79ce15b"),
					TagId = Guid.Parse("7d5d4e96-d0fa-440e-914f-1667b6ef54c1")
				},

				// Missing
				new GameTags
				{
					GameId = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31"),
					TagId = Guid.Parse("ad95ed3f-284a-45d4-adc2-75b4f3681301")
				},

				//Bloodmall
				new GameTags
				{
					GameId = Guid.Parse("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
					TagId = Guid.Parse("0a0af88e-6860-445b-b7ce-b10f46e8dea3")
				},

				//Thunderhead
				new GameTags
				{
					GameId = Guid.Parse("34209460-1478-4545-9f15-723eeefc5697"),
					TagId = Guid.Parse("3ef686ac-5e11-45d8-afab-223d2d149f6f")
				},
				new GameTags
				{
					GameId = Guid.Parse("34209460-1478-4545-9f15-723eeefc5697"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("34209460-1478-4545-9f15-723eeefc5697"),
					TagId = Guid.Parse("0a0af88e-6860-445b-b7ce-b10f46e8dea3")
				},

				//Evaluation
				new GameTags
				{
					GameId = Guid.Parse("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
					TagId = Guid.Parse("ab6e601e-52c3-45dc-97c3-1c6e84732769")
				},
				new GameTags
				{
					GameId = Guid.Parse("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
					TagId = Guid.Parse("ad95ed3f-284a-45d4-adc2-75b4f3681301")
				},

				//Dominoid
				new GameTags
				{
					GameId = Guid.Parse("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
					TagId = Guid.Parse("fcf4e928-dc77-405c-a13e-1d1d5e308d6b")
				},
				new GameTags
				{
					GameId = Guid.Parse("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
					TagId = Guid.Parse("37223e27-41ad-44cb-9332-d985dbc9f708")
				},
				new GameTags
				{
					GameId = Guid.Parse("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
					TagId = Guid.Parse("ad95ed3f-284a-45d4-adc2-75b4f3681301")
				},

				//DiggingHour
				new GameTags
				{
					GameId = Guid.Parse("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
					TagId = Guid.Parse("3ef686ac-5e11-45d8-afab-223d2d149f6f")
				},
				new GameTags
				{
					GameId = Guid.Parse("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
					TagId = Guid.Parse("0a0af88e-6860-445b-b7ce-b10f46e8dea3")
				},

				//Dispatched
				new GameTags
				{
					GameId = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8"),
					TagId = Guid.Parse("0a0af88e-6860-445b-b7ce-b10f46e8dea3")
				},
				new GameTags
				{
					GameId = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8"),
					TagId = Guid.Parse("ad95ed3f-284a-45d4-adc2-75b4f3681301")
				},
				new GameTags
				{
					GameId = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8"),
					TagId = Guid.Parse("3ef686ac-5e11-45d8-afab-223d2d149f6f")
				},

				//SecurityBooth
				new GameTags
				{
					GameId = Guid.Parse("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
					TagId = Guid.Parse("b9e9a223-25b3-491b-ba92-e185a74d82ab")
				},
				new GameTags
				{
					GameId = Guid.Parse("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
					TagId = Guid.Parse("fcf4e928-dc77-405c-a13e-1d1d5e308d6b")
				},
				new GameTags
				{
					GameId = Guid.Parse("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
					TagId = Guid.Parse("e4e35307-2071-4a75-88fc-579db0077703")
				},

				//Atlyss
				new GameTags
				{
					GameId = Guid.Parse("152e3482-be53-44db-93e6-785823f6224e"),
					TagId = Guid.Parse("ad95ed3f-284a-45d4-adc2-75b4f3681301")
				},
				new GameTags
				{
					GameId = Guid.Parse("152e3482-be53-44db-93e6-785823f6224e"),
					TagId = Guid.Parse("ab6e601e-52c3-45dc-97c3-1c6e84732769")
				},
				new GameTags
				{
					GameId = Guid.Parse("152e3482-be53-44db-93e6-785823f6224e"),
					TagId = Guid.Parse("7d5d4e96-d0fa-440e-914f-1667b6ef54c1")
				},

				//Tomato
				new GameTags
				{
					GameId = Guid.Parse("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
					TagId = Guid.Parse("8c202501-893d-427e-9faf-47e2f1d6ba2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
					TagId = Guid.Parse("fcf4e928-dc77-405c-a13e-1d1d5e308d6b")
				},
				new GameTags
				{
					GameId = Guid.Parse("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
					TagId = Guid.Parse("8c13bf31-2b82-4452-9a5c-2968c01e1dac")
				},

				//Leftovers
				new GameTags
				{
					GameId = Guid.Parse("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
					TagId = Guid.Parse("46c0001e-beb3-4291-885a-f076e53f40fd")
				},
				new GameTags
				{
					GameId = Guid.Parse("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				},
				new GameTags
				{
					GameId = Guid.Parse("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
					TagId = Guid.Parse("6cc4c52b-3b0e-4641-9997-8a1e6c29753b")
				},

				//TheStation
				new GameTags
				{
					GameId = Guid.Parse("791a4c74-d469-4432-bd76-c5ace021ce8e"),
					TagId = Guid.Parse("3ef686ac-5e11-45d8-afab-223d2d149f6f")
				},
				new GameTags
				{
					GameId = Guid.Parse("791a4c74-d469-4432-bd76-c5ace021ce8e"),
					TagId = Guid.Parse("0a0af88e-6860-445b-b7ce-b10f46e8dea3")
				},
				new GameTags
				{
					GameId = Guid.Parse("791a4c74-d469-4432-bd76-c5ace021ce8e"),
					TagId = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d")
				}
			);
		}
	}
}
