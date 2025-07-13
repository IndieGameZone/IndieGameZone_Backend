using IndieGameZone.Domain.Constants;
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
			builder.Property(a => a.ProgressLevel);
			builder.Property(a => a.Type).HasConversion<string>().HasMaxLength(20);

			builder.HasMany(a => a.UserAchievements)
				.WithOne(ua => ua.Achievement)
				.HasForeignKey(ua => ua.AchievementId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				new Achievements { Id = Guid.Parse("fef0c70d-cf7b-4c90-9865-383e660fda8a"), Name = "First Purchase", ProgressLevel = 1, Type = AchievementType.GamePurchase },
				new Achievements { Id = Guid.Parse("56e5cd8d-2d46-45dc-9006-f71920beea40"), Name = "Buy 10 Games", ProgressLevel = 10, Type = AchievementType.GamePurchase },
				new Achievements { Id = Guid.Parse("9c60bc27-9c8a-4be3-9e0d-1f4e96cb59a7"), Name = "Buy 50 Games", ProgressLevel = 50, Type = AchievementType.GamePurchase },

				new Achievements { Id = Guid.Parse("b0ea7c96-6d5c-4199-9029-7f04e7502f66"), Name = "Make first Post", ProgressLevel = 1, Type = AchievementType.Post },
				new Achievements { Id = Guid.Parse("5291fbd1-9926-4904-92bc-7f36c738c189"), Name = "Make 10 Posts", ProgressLevel = 10, Type = AchievementType.Post },
				new Achievements { Id = Guid.Parse("47c0b28f-43d2-496e-bfcb-f9df5aa2048d"), Name = "Make 50 Posts", ProgressLevel = 50, Type = AchievementType.Post },

				new Achievements { Id = Guid.Parse("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b"), Name = "Comment first time", ProgressLevel = 1, Type = AchievementType.Comment },
				new Achievements { Id = Guid.Parse("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3"), Name = "Comment 10 Times", ProgressLevel = 10, Type = AchievementType.Comment },
				new Achievements { Id = Guid.Parse("2190f97e-1533-4c91-9152-f7ae9ec6f8c0"), Name = "Comment 50 Times", ProgressLevel = 50, Type = AchievementType.Comment },

				new Achievements { Id = Guid.Parse("8e8cbf44-001f-4060-bd8a-bc6213a81cc0"), Name = "Like first Post", ProgressLevel = 1, Type = AchievementType.Like },
				new Achievements { Id = Guid.Parse("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c"), Name = "Like 10 Posts", ProgressLevel = 10, Type = AchievementType.Like },
				new Achievements { Id = Guid.Parse("d49ff353-2b75-4879-8a0b-4d7c16ed4a69"), Name = "Like 50 Posts", ProgressLevel = 50, Type = AchievementType.Like },

				new Achievements { Id = Guid.Parse("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6"), Name = "Follow 5 Developers", ProgressLevel = 5, Type = AchievementType.Follow },
				new Achievements { Id = Guid.Parse("b186aeb1-033f-4937-a24c-d11b1989e7e2"), Name = "Follow 10 Developers", ProgressLevel = 10, Type = AchievementType.Follow },
				new Achievements { Id = Guid.Parse("5a8d9a1a-4b12-464b-8a70-d0309c3f355d"), Name = "Follow 50 Developers", ProgressLevel = 50, Type = AchievementType.Follow }

			);
		}
	}
}
