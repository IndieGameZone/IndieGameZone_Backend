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
                new Achievements { Id = Guid.Parse("de08b771-763c-4e33-a97f-c627a2e790df"), Name = "Buy 100 Games" },
                new Achievements { Id = Guid.Parse("fbdc5b33-eef1-42aa-897f-e8f7de9f3179"), Name = "Buy 250 Games" },
                new Achievements { Id = Guid.Parse("6a95c38c-e765-4a9b-9adf-d640eeedb214"), Name = "Buy 500 Games" },
                new Achievements { Id = Guid.Parse("a94e99cb-9a99-4d4f-879b-4fa2f4b8a4c7"), Name = "Buy 1000 Games (Platinum)" },

                new Achievements { Id = Guid.Parse("b0ea7c96-6d5c-4199-9029-7f04e7502f66"), Name = "Post 10 Threads" },
                new Achievements { Id = Guid.Parse("5291fbd1-9926-4904-92bc-7f36c738c189"), Name = "Post 50 Threads" },
                new Achievements { Id = Guid.Parse("47c0b28f-43d2-496e-bfcb-f9df5aa2048d"), Name = "Post 100 Threads" },
                new Achievements { Id = Guid.Parse("f9d84647-6f77-4684-a39c-f5e671c181a1"), Name = "Post 250 Threads" },
                new Achievements { Id = Guid.Parse("8232bff1-9cc1-4b1d-aabd-03cf0b3b2448"), Name = "Post 500 Threads" },
                new Achievements { Id = Guid.Parse("e1719829-fd9f-4a14-bfe4-6d524b01300b"), Name = "Post 1000 Threads (Platinum)" },

                new Achievements { Id = Guid.Parse("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b"), Name = "Comment 10 Times" },
                new Achievements { Id = Guid.Parse("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3"), Name = "Comment 50 Times" },
                new Achievements { Id = Guid.Parse("2190f97e-1533-4c91-9152-f7ae9ec6f8c0"), Name = "Comment 100 Times" },
                new Achievements { Id = Guid.Parse("a76b7914-3d28-4bb9-8a6e-96f3953447e3"), Name = "Comment 250 Times" },
                new Achievements { Id = Guid.Parse("0d8f0c15-cdb8-4f99-a84e-d749474f9f98"), Name = "Comment 500 Times" },
                new Achievements { Id = Guid.Parse("bbf75b11-92d5-4bcf-8c2e-bb0c6a9b50e5"), Name = "Comment 1000 Times (Platinum)" },

                new Achievements { Id = Guid.Parse("8e8cbf44-001f-4060-bd8a-bc6213a81cc0"), Name = "Like 10 Posts" },
                new Achievements { Id = Guid.Parse("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c"), Name = "Like 50 Posts" },
                new Achievements { Id = Guid.Parse("d49ff353-2b75-4879-8a0b-4d7c16ed4a69"), Name = "Like 100 Posts" },
                new Achievements { Id = Guid.Parse("70e2f6b1-b748-4ce7-8b71-84995c37cd3c"), Name = "Like 250 Posts" },
                new Achievements { Id = Guid.Parse("2d3fcb09-5a7c-4268-9d86-248eb28a166d"), Name = "Like 500 Posts" },
                new Achievements { Id = Guid.Parse("bdde7288-0ec3-4726-9760-c802f4527c45"), Name = "Like 1000 Posts (Platinum)" },

                new Achievements { Id = Guid.Parse("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6"), Name = "Follow 10 Developers" },
                new Achievements { Id = Guid.Parse("b186aeb1-033f-4937-a24c-d11b1989e7e2"), Name = "Follow 50 Developers" },
                new Achievements { Id = Guid.Parse("5a8d9a1a-4b12-464b-8a70-d0309c3f355d"), Name = "Follow 100 Developers" },
                new Achievements { Id = Guid.Parse("ec14ae35-0147-470e-a927-03b999924b53"), Name = "Follow 250 Developers" },
                new Achievements { Id = Guid.Parse("ae30b8aa-cf63-474d-b42c-9b8e4479b31b"), Name = "Follow 500 Developers" },
                new Achievements { Id = Guid.Parse("8d1c8d65-2d84-4c86-a5b1-16de0aee3a34"), Name = "Follow 1000 Developers (Platinum)" },

                new Achievements { Id = Guid.Parse("a67ae3f1-e9fd-47cd-bc80-9a51753f52f1"), Name = "Wishlist 10 Games" },
                new Achievements { Id = Guid.Parse("61a86ea6-3db1-4a99-afe8-dbd178470cc2"), Name = "Wishlist 50 Games" },
                new Achievements { Id = Guid.Parse("24e0f221-e9a0-4c4d-a71d-1ed16ad6d36a"), Name = "Wishlist 100 Games" },
                new Achievements { Id = Guid.Parse("348ea355-5d52-4120-8794-b9022b4d3172"), Name = "Wishlist 250 Games" },
                new Achievements { Id = Guid.Parse("187f58aa-ecc1-4e65-9b76-f3fe37213ae3"), Name = "Wishlist 500 Games" },
                new Achievements { Id = Guid.Parse("6e1ea6cb-8d1d-4b4b-9316-195270d92c0f"), Name = "Wishlist 1000 Games (Platinum)" },

                new Achievements { Id = Guid.Parse("52cb47a2-2d10-4662-a36d-4f3fefca498b"), Name = "Complete Profile (Fill all fields)" },
                new Achievements { Id = Guid.Parse("1fc7e4c8-6a14-4b10-a54f-28c14a5bfae4"), Name = "Early Adopter (Joined at launch)" },
                new Achievements { Id = Guid.Parse("6b8a7ab1-bb17-4958-91c6-ff6d7a2ea880"), Name = "Streak Master (30-day login streak)" },
                new Achievements { Id = Guid.Parse("45a6e417-48aa-4ad8-8b89-0bc72c4edb62"), Name = "Ultimate Streak (365-day streak)" },
                new Achievements { Id = Guid.Parse("9e9c76d3-8d24-4f14-aaf1-c85cbb20c29d"), Name = "Reviewer (Write 10 reviews)" },
                new Achievements { Id = Guid.Parse("72b6b5e2-bff5-49ec-9770-b7a0bfa452f8"), Name = "Critic (Write 50 reviews)" },
                new Achievements { Id = Guid.Parse("ee7743cf-fdb3-4abf-85b1-9fa84b33fd06"), Name = "Top Fan (Like 100+ posts in a month)" },
                new Achievements { Id = Guid.Parse("e4a10952-4869-499e-90f2-743ef6ad2c0c"), Name = "Explorer (Visit all categories)" },
                new Achievements { Id = Guid.Parse("0f7b9b0f-f527-43cc-92f1-92fe4d03d09d"), Name = "Omniscient (View every game page)" },
                new Achievements { Id = Guid.Parse("6fc5791d-b726-41df-b524-d5286f316d69"), Name = "Bug Hunter (Report 10 bugs)" },
                new Achievements { Id = Guid.Parse("1a7902b5-b931-4050-a0bc-4df6bbd0b2a1"), Name = "Philanthropist (Gift 10 games)" },
                new Achievements { Id = Guid.Parse("ccae8845-7497-4cb9-9a0c-cd5102ce08f2"), Name = "Tastemaker (Get 100 likes on a post)" },
                new Achievements { Id = Guid.Parse("79447ee2-7653-4b48-90db-8c4a607b9db9"), Name = "Legendary Tastemaker (Get 1000 likes on a post)" }
            );
        }
    }
}
