using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class AchievementConfiguration : IEntityTypeConfiguration<Achievements>
	{
		public void Configure(EntityTypeBuilder<Achievements> builder)
		{
			builder.HasKey(a => a.Id);
			builder.Property(a => a.Name);

			builder.HasMany(a => a.UserAchievements)
				.WithOne(ua => ua.Achievement)
				.HasForeignKey(ua => ua.AchievementId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				new Achievements { Id = Guid.Parse("fef0c70d-cf7b-4c90-9865-383e660fda8a"), Name = "First Purchase" },
				new Achievements { Id = Guid.Parse("56e5cd8d-2d46-45dc-9006-f71920beea40"), Name = "Buy 10 Games" },
				new Achievements { Id = Guid.Parse("9c60bc27-9c8a-4be3-9e0d-1f4e96cb59a7"), Name = "Buy 50 Games" },

				new Achievements { Id = Guid.Parse("b0ea7c96-6d5c-4199-9029-7f04e7502f66"), Name = "Post 10 Threads" },
				new Achievements { Id = Guid.Parse("5291fbd1-9926-4904-92bc-7f36c738c189"), Name = "Post 50 Threads" },
				new Achievements { Id = Guid.Parse("47c0b28f-43d2-496e-bfcb-f9df5aa2048d"), Name = "Post 100 Threads" },

				new Achievements { Id = Guid.Parse("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b"), Name = "Comment 10 Times" },
				new Achievements { Id = Guid.Parse("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3"), Name = "Comment 50 Times" },
				new Achievements { Id = Guid.Parse("2190f97e-1533-4c91-9152-f7ae9ec6f8c0"), Name = "Comment 100 Times" },

				new Achievements { Id = Guid.Parse("8e8cbf44-001f-4060-bd8a-bc6213a81cc0"), Name = "Like 10 Posts" },
				new Achievements { Id = Guid.Parse("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c"), Name = "Like 50 Posts" },
				new Achievements { Id = Guid.Parse("d49ff353-2b75-4879-8a0b-4d7c16ed4a69"), Name = "Like 100 Posts" },

				new Achievements { Id = Guid.Parse("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6"), Name = "Follow 10 Developers" },
				new Achievements { Id = Guid.Parse("b186aeb1-033f-4937-a24c-d11b1989e7e2"), Name = "Follow 50 Developers" },
				new Achievements { Id = Guid.Parse("5a8d9a1a-4b12-464b-8a70-d0309c3f355d"), Name = "Follow 100 Developers" },

				new Achievements { Id = Guid.Parse("a67ae3f1-e9fd-47cd-bc80-9a51753f52f1"), Name = "Wishlist 10 Games" },
				new Achievements { Id = Guid.Parse("61a86ea6-3db1-4a99-afe8-dbd178470cc2"), Name = "Wishlist 50 Games" },
				new Achievements { Id = Guid.Parse("24e0f221-e9a0-4c4d-a71d-1ed16ad6d36a"), Name = "Wishlist 100 Games" }

			);
		}
	}
}
