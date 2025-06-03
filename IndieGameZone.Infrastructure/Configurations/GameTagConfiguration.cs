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
				}
			);
		}
	}
}
