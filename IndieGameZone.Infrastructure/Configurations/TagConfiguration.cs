using IndieGameZone.Domain.Constants;
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
			builder.Property(t => t.Type).HasConversion<string>().HasMaxLength(10);

			builder.HasMany(t => t.GameTags)
				.WithOne(gt => gt.Tag)
				.HasForeignKey(gt => gt.TagId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(pt => pt.PostTags)
				.WithOne(pt => pt.Tag)
				.HasForeignKey(pt => pt.TagId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				// Genres
				new Tags { Id = Guid.Parse("cd543d0f-1761-4874-945b-53863f00942b"), Name = "Adventure", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("5452906a-03b1-45df-b4f0-a65398885171"), Name = "Visual Novel", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("4d1a6086-ed27-4767-8fb6-4c4af12c384c"), Name = "Role-Playing", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("1c175c84-379e-43dc-a95a-aafd910d6a00"), Name = "Action", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("130d3ae5-7c92-4d37-9082-13226dd0d9af"), Name = "Platformer", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("71918e61-bb0b-4ca1-975a-616d869769bf"), Name = "Puzzle", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("b9e9a223-25b3-491b-ba92-e185a74d82ab"), Name = "Simulation", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("f57af0bf-7612-4b08-84f3-be98a842f932"), Name = "Interactive Fiction", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("46c0001e-beb3-4291-885a-f076e53f40fd"), Name = "Survival", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("c04cba4a-a827-4a49-b61b-f02798ef17c9"), Name = "Shooter", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("c7cee309-8f38-43fd-8512-e40e4d6f1ccd"), Name = "Strategy", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("a137e663-30d5-4ed9-8aa3-b9b500f18de7"), Name = "Card Game", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("41c1f4f5-4cf0-411b-bb15-e59f15b04762"), Name = "Fighting", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("aa592c96-400a-4c67-bf18-3b82823e9ef9"), Name = "Racing", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("8c202501-893d-427e-9faf-47e2f1d6ba2d"), Name = "Education", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("a0f1e28b-a439-4e72-aed8-0baddbb515c2"), Name = "Rhythm", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d"), Name = "Horror", Type = TagTypeEnum.Game },

				// Themes
				new Tags { Id = Guid.Parse("fcf4e928-dc77-405c-a13e-1d1d5e308d6b"), Name = "2D", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("37223e27-41ad-44cb-9332-d985dbc9f708"), Name = "Pixel Art", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("3ef686ac-5e11-45d8-afab-223d2d149f6f"), Name = "3D", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("0a0af88e-6860-445b-b7ce-b10f46e8dea3"), Name = "First-Person", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("b6dd9e32-eaf5-4942-9c18-566421ca2e90"), Name = "Top-Down", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("f503a37e-dff0-45a8-8ae8-58ccefa4c9d3"), Name = "Low-Poly", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("9636813b-f393-4adb-b9a7-44f877f67ae5"), Name = "8-Bit", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("3e7412cc-2817-4d03-9dcf-7c3c7e619186"), Name = "16-Bit", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("f3527a12-03c3-417d-9dd1-6130e7fcfe3e"), Name = "16x16", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("f8d13d4f-1a7b-406b-aa6e-4f37d8cebacf"), Name = "Hand-Drawn", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("8c13bf31-2b82-4452-9a5c-2968c01e1dac"), Name = "Colorful", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("22ad33b0-8358-4054-aa6b-59a2b5296842"), Name = "Isometric", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("aa580b0a-12c6-4d95-8d4f-c68fdd8cfbd9"), Name = "32x32", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("569a2ff2-5259-4467-9824-a3f2c5a595f7"), Name = "1-Bit", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("621f12a7-89cb-4b97-83c0-cd3e84774dd4"), Name = "Third-Person", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("ab6e601e-52c3-45dc-97c3-1c6e84732769"), Name = "Cartoon", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("bc50196f-6aa1-49c2-9347-33f4ef15b8d6"), Name = "Black and White", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("8fdfc2fc-b9ae-49a4-9aa5-e986cdf9f65a"), Name = "Neon", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("62c2fe13-f1d2-4905-b3e1-166598e091fb"), Name = "8x8", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("8db1d14f-c82c-4a06-bd60-456350a62594"), Name = "Non-Eucledian", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("e27b19a2-12d7-4a55-a8e4-7ff3487db712"), Name = "Pastel", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("48239920-0a09-438e-8320-6b822e01f8bb"), Name = "Two Colors", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("9c685bd3-c75f-48df-8043-20c2fe181e7f"), Name = "Watercolor", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("048cbb0b-d39e-4f1d-b1d7-e28aeb6fc6e6"), Name = "Grayscale", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("7e3be5eb-bf83-4450-9ecb-70535267d3ea"), Name = "Flat-Shading", Type = TagTypeEnum.Game },

				// Game Engines & Tools
				new Tags { Id = Guid.Parse("e4e35307-2071-4a75-88fc-579db0077703"), Name = "Unity", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("611e1869-df31-4ec1-b063-7c9ae49bfb30"), Name = "RPG Maker", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("6cc4c52b-3b0e-4641-9997-8a1e6c29753b"), Name = "Godot", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("cd37e2fc-cb7e-45c3-90d6-87c690a2aaf3"), Name = "Ren’Py", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("7d5d4e96-d0fa-440e-914f-1667b6ef54c1"), Name = "Unreal Engine", Type = TagTypeEnum.Game },

				// Community Tags
				new Tags { Id = Guid.Parse("7cc2168e-4ad6-409f-9868-bd59df589d8c"), Name = "Guide 📖", Type = TagTypeEnum.Post },
				new Tags { Id = Guid.Parse("e50d38ef-93f6-4f52-a55b-0dbf8188f91f"), Name = "Discussion 💬", Type = TagTypeEnum.Post },
				new Tags { Id = Guid.Parse("85a1abde-9980-4cc7-976e-1d4135ffddff"), Name = "Review ★", Type = TagTypeEnum.Post },
				new Tags { Id = Guid.Parse("229ef81c-f48f-49ae-a9a1-149f71d54d77"), Name = "Showcase 🎨", Type = TagTypeEnum.Post },
				new Tags { Id = Guid.Parse("da2b3f32-20fc-4a62-a16f-f87fbe4696fb"), Name = "Question ❓", Type = TagTypeEnum.Post },

				// Modes
				new Tags { Id = Guid.Parse("510d85f4-c8dc-4228-93cb-311809751bed"), Name = "Multiplayer", Type = TagTypeEnum.Game },
				new Tags { Id = Guid.Parse("ad95ed3f-284a-45d4-adc2-75b4f3681301"), Name = "Singleplayer", Type = TagTypeEnum.Game }
			);
		}
	}
}
