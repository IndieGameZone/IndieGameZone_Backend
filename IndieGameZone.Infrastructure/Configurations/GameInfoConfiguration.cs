using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GameInfoConfiguration : IEntityTypeConfiguration<GameInfos>
	{
		public void Configure(EntityTypeBuilder<GameInfos> builder)
		{
			builder.HasKey(g => g.Id);
			builder.Property(g => g.Image);
			builder.Property(g => g.Title).HasMaxLength(100);
			builder.Property(g => g.Description);

			builder.HasOne(g => g.Games)
				.WithMany(g => g.GameInfos)
				.HasForeignKey(g => g.GameId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasData(
				new GameInfos
				{
					Id = Guid.Parse("2212b056-b7e1-4bd4-a258-aae3e24f9a87"),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage1.png",
					Title = "Steam release features Hard Mode, as well as double the story!",
					Description = "You are in the backseat of your parent's car during a long drive. As your parents begin fighting, your hand-held game is your only source of entertainment. But the game begins to mirror real life... Collect items on your hand-held game to send them to the backseat and use them to defend against the monstrosity that's trying to make its way into the backseat with you.",
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7")
				},
				new GameInfos
				{
					Id = Guid.Parse("396cf491-b737-4983-a65e-42ecd36080d7"),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage2.png",
					Title = "SURVIVE THE NIGHT DRIVE",
					Description = "Your drive home from grandma's is interrupted by an unexpected detour. Play a hand-held game in the backseat as your parent's drive.",
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7")
				},
				new GameInfos
				{
					Id = Guid.Parse("dc5e81ec-24b6-4109-ba9f-e9de4ad9a855"),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage3.png",
					Title = "RETRO GAMING",
					Description = "Your hand-held game is beginning to mirror reality... Supplies you collect in the game will be sent to the backseat.",
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7")
				},
				new GameInfos
				{
					Id = Guid.Parse("81738026-cd42-482c-a692-f080a6fe9240"),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage4.png",
					Title = "TRAPPED IN THE DEADSEAT",
					Description = "A deadly monstrosity wants to join you in the backseat. Juggle your supplies and defend all sides. In this car, there’s only onwards to drive, and nowhere to run.",
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7")
				},
				new GameInfos
				{
					Id = Guid.Parse("d3e36747-a19a-41ff-b8a1-1c274e378dab"),
					Image = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage5.png",
					Title = "THE STORY",
					Description = "Your parents can't get along, and you can’t ignore it, no matter how deep you immerse yourself in your game. If only you could get away from it all and escape to somewhere better. And seemingly, the voice in your game says you can.",
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7")
				}
			);
		}
	}
}
