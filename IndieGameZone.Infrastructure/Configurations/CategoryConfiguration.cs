using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Categories>
	{
		public void Configure(EntityTypeBuilder<Categories> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Name).HasMaxLength(100);

			builder.HasMany(c => c.Games)
				.WithOne(g => g.Category)
				.HasForeignKey(g => g.CategoryId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
                new Categories { Id = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), Name = "Adventure" },
                new Categories { Id = Guid.Parse("77c89b32-78e3-4fea-915f-4b8df819ffa2"), Name = "Visual Novel" },
                new Categories { Id = Guid.Parse("89a4e6d2-2cfe-4474-9b96-6d3595ad4705"), Name = "Role-Playing" },
                new Categories { Id = Guid.Parse("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), Name = "Action" },
                new Categories { Id = Guid.Parse("39b71d75-ed24-461a-8dbf-e4fa9ae425fc"), Name = "Platformer" },
                new Categories { Id = Guid.Parse("bca8721b-c323-44a1-afcf-876e206ab035"), Name = "Puzzle" },
                new Categories { Id = Guid.Parse("2d740ce2-a803-4b32-8df8-ab5139203742"), Name = "Simulation" },
                new Categories { Id = Guid.Parse("cd1fb8a2-c34e-4fc4-bbbd-9931a0c6ce0e"), Name = "Interactive Fiction" },
                new Categories { Id = Guid.Parse("ab34908d-20dc-43bd-b80d-eac5b59d6238"), Name = "Survival" },
                new Categories { Id = Guid.Parse("4d84bb23-8644-4720-8344-d4a9d0433d35"), Name = "Shooter" },
                new Categories { Id = Guid.Parse("929c6ef0-41e5-4bc5-9ef9-86f0703b9c20"), Name = "Strategy" },
				new Categories { Id = Guid.Parse("592e7334-c896-46f6-ad6c-a781a2ab7219"), Name = "Card Game" },
                new Categories { Id = Guid.Parse("b277ba85-f89b-4617-a464-49cda6e8d387"), Name = "Fighting" },
                new Categories { Id = Guid.Parse("88fd3b90-179a-4c18-8c3a-5f3929992e0a"), Name = "Racing" },
                new Categories { Id = Guid.Parse("5e1afbc9-31dd-417d-ae49-baa45d6d5797"), Name = "Educational" },
                new Categories { Id = Guid.Parse("a5a8e1af-bbea-4029-99fe-42912e7c7ba2"), Name = "Rhythm" },
                new Categories { Id = Guid.Parse("3623f541-4b87-4174-bfce-dd2b027c7a33"), Name = "Sports" }

			);
		}
	}
}
