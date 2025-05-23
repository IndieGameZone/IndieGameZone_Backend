using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class TagConfiguration : IEntityTypeConfiguration<Tags>
	{
		public void Configure(EntityTypeBuilder<Tags> builder)
		{
			builder.HasKey(t => t.Id);
			builder.Property(t => t.Name).HasMaxLength(100);

			builder.HasMany(t => t.GameTags)
				.WithOne(gt => gt.Tag)
				.HasForeignKey(gt => gt.TagId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(pt => pt.PostTags)
				.WithOne(pt => pt.Tag)
				.HasForeignKey(pt => pt.TagId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				new Tags { Id = Guid.Parse("1c175c84-379e-43dc-a95a-aafd910d6a00"), Name = "Action" },
				new Tags { Id = Guid.Parse("cd543d0f-1761-4874-945b-53863f00942b"), Name = "Adventure" },
				new Tags { Id = Guid.Parse("4d1a6086-ed27-4767-8fb6-4c4af12c384c"), Name = "Role-Playing" },
				new Tags { Id = Guid.Parse("b9e9a223-25b3-491b-ba92-e185a74d82ab"), Name = "Simulation" },
				new Tags { Id = Guid.Parse("c7cee309-8f38-43fd-8512-e40e4d6f1ccd"), Name = "Strategy" },
				new Tags { Id = Guid.Parse("3d76f55a-a3c8-4f51-a959-6a36c90ba4bd"), Name = "Sports" },
				new Tags { Id = Guid.Parse("71918e61-bb0b-4ca1-975a-616d869769bf"), Name = "Puzzle" },
				new Tags { Id = Guid.Parse("b92d60b0-0447-4ef2-9233-088b4d91cce5"), Name = "Horror" },
				new Tags { Id = Guid.Parse("aa592c96-400a-4c67-bf18-3b82823e9ef9"), Name = "Racing" },
				new Tags { Id = Guid.Parse("41c1f4f5-4cf0-411b-bb15-e59f15b04762"), Name = "Fighting" },
				new Tags { Id = Guid.Parse("c04cba4a-a827-4a49-b61b-f02798ef17c9"), Name = "Shooter" },
				new Tags { Id = Guid.Parse("9f3617ec-c56d-4423-ad07-43c904ef6542"), Name = "Stealth" },
				new Tags { Id = Guid.Parse("78530cfe-1488-49ab-befb-0ee332cfe7a1"), Name = "Open World" },
				new Tags { Id = Guid.Parse("46c0001e-beb3-4291-885a-f076e53f40fd"), Name = "Survival" },
				new Tags { Id = Guid.Parse("a137e663-30d5-4ed9-8aa3-b9b500f18de7"), Name = "BoardGame" },
				new Tags { Id = Guid.Parse("a39f8614-3936-48cf-bb4a-01c590486bdc"), Name = "Indie" },
				new Tags { Id = Guid.Parse("510d85f4-c8dc-4228-93cb-311809751bed"), Name = "Multiplayer" },
				new Tags { Id = Guid.Parse("e4cc8cbe-9b71-416d-967c-b88ad852be45"), Name = "Singleplayer" },
				new Tags { Id = Guid.Parse("72229e67-bba2-41ae-9fee-84c97d01d1fb"), Name = "MacOS Game" },
				new Tags { Id = Guid.Parse("c620e06f-49b2-4cc7-8be5-19d63e8d915a"), Name = "Linux Game" },
				new Tags { Id = Guid.Parse("cb631ff7-d19b-40a5-b948-a3b138703e19"), Name = "Windows Game" },
				new Tags { Id = Guid.Parse("fcf4e928-dc77-405c-a13e-1d1d5e308d6b"), Name = "2D" },
				new Tags { Id = Guid.Parse("3ef686ac-5e11-45d8-afab-223d2d149f6f"), Name = "3D" },
				new Tags { Id = Guid.Parse("37223e27-41ad-44cb-9332-d985dbc9f708"), Name = "Pixel Art" },
				new Tags { Id = Guid.Parse("83f90ed3-38f1-40a9-88e5-8ce4a728a4a4"), Name = "Kungfu" }
			);
		}
	}
}
