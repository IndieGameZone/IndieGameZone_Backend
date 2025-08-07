using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GameConfiguration : IEntityTypeConfiguration<Games>
	{
		public void Configure(EntityTypeBuilder<Games> builder)
		{
			builder.HasKey(g => g.Id);
			builder.Property(g => g.Name).HasMaxLength(100);
			builder.Property(g => g.CoverImage);
			builder.Property(g => g.VideoLink);
			builder.Property(g => g.Description);
			builder.Property(g => g.VersionDescription);
			builder.Property(g => g.AllowDonation);
			builder.Property(g => g.Status).HasConversion<string>().HasMaxLength(50);
			builder.Property(g => g.Visibility).HasConversion<string>().HasMaxLength(50);
			builder.Property(g => g.CensorStatus).HasConversion<string>().HasMaxLength(50);
			builder.Property(g => g.InstallInstruction);
			builder.Property(g => g.ShortDescription);
			builder.Property(g => g.Price);
			builder.Property(g => g.NumberOfDownloads);
			builder.Property(g => g.CreatedAt);
			builder.Property(g => g.UpdatedAt);
			builder.Property(g => g.CensoredAt);
			builder.Property(g => g.AverageSession);
			builder.Property(a => a.IsDeleted);

			builder.HasMany(g => g.GameLanguages)
				.WithOne(gl => gl.Game)
				.HasForeignKey(gl => gl.GameId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasMany(g => g.GameTags)
				.WithOne(gt => gt.Game)
				.HasForeignKey(gt => gt.GameId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(g => g.Category)
				.WithMany(c => c.Games)
				.HasForeignKey(g => g.CategoryId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.GamePlatforms)
				.WithOne(gp => gp.Game)
				.HasForeignKey(gp => gp.GameId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasMany(g => g.GameImages)
				.WithOne(gi => gi.Games)
				.HasForeignKey(gi => gi.GameId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(g => g.AgeRestriction)
				.WithMany(ar => ar.Games)
				.HasForeignKey(g => g.AgeRestrictionId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(g => g.Developer)
				.WithMany(d => d.Games)
				.HasForeignKey(g => g.DeveloperId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Reviews)
				.WithOne(r => r.Game)
				.HasForeignKey(r => r.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Discounts)
				.WithOne(d => d.Game)
				.HasForeignKey(d => d.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.CommercialRegistrations)
				.WithOne(cr => cr.Game)
				.HasForeignKey(cr => cr.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Wishlists)
				.WithOne(w => w.Game)
				.HasForeignKey(w => w.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Libraries)
				.WithOne(l => l.Game)
				.HasForeignKey(l => l.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Posts)
				.WithOne(p => p.Game)
				.HasForeignKey(p => p.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Reports)
				.WithOne(r => r.Game)
				.HasForeignKey(r => r.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.GameRecommendations)
				.WithOne(gr => gr.Game)
				.HasForeignKey(gr => gr.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Transactions)
				.WithOne(t => t.Game)
				.HasForeignKey(t => t.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.GameCensorLogs)
				.WithOne(gcl => gcl.Game)
				.HasForeignKey(gcl => gcl.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.Orders)
				.WithOne(o => o.Game)
				.HasForeignKey(o => o.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasMany(g => g.GamePriceLogs)
				.WithOne(gpl => gpl.Game)
				.HasForeignKey(gpl => gpl.GameId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				new Games
				{
					Id = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7"),
					Name = "The Deadseat",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatCoverImage.png",
					VideoLink = "https://www.youtube.com/watch?v=Q4A2c8-BN78&t=2s",
					ShortDescription = "A short horror game where you play a hand-held game in the backseat during a long drive home.",
					Description = "<h4>Steam release features Hard Mode, as well as double the story!</h4><p>You are in the backseat of your parent's car during a long drive. As your parents begin fighting, your hand-held game is your only source of entertainment. But the game begins to mirror real life... Collect items on your hand-held game to send them to the backseat and use them to defend against the monstrosity that's trying to make its way into the backseat with you.</p><h4>SURVIVE THE NIGHT DRIVE</h4><p>Your drive home from grandma's is interrupted by an unexpected detour. Play a hand-held game in the backseat as your parent's drive.</p><h4>RETRO GAMING</h4><p>Your hand-held game is beginning to mirror reality... Supplies you collect in the game will be sent to the backseat.</p><h4>TRAPPED IN THE DEADSEAT</h4><p>A deadly monstrosity wants to join you in the backseat. Juggle your supplies and defend all sides. In this car, there&rsquo;s only onwards to drive, and nowhere to run.</p><h4>THE STORY</h4><p>Your parents can't get along, and you can&rsquo;t ignore it, no matter how deep you immerse yourself in your game. If only you could get away from it all and escape to somewhere better. And seemingly, the voice in your game says you can.</p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 100000,
					NumberOfDownloads = 100,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("7a03afa3-2635-43bd-a58c-daeb80d3cef7"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("5763f752-914c-4436-803f-4410118774a3"),
					Name = "MidnightShift",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftCoverImage.png",
					VideoLink = "https://www.youtube.com/watch?v=v1oeNEKiwTg",
					ShortDescription = "Escape a mannequin storage facility.",
					Description = "<p><strong>Announcement</strong>: Midnight Shift 1.2 has been released.</p><ul><li>Enhanced 4:3 VHS / found footage appearance.</li><li>The animation for the ending has been updated.</li><li>Increased field-of-view.</li><li>Updated main menu.</li></ul><p><strong>Synopsis</strong></p><p><em>Midnight Shift</em>&nbsp;puts players in the role as an ordinary security guard for a mannequin storage facility. At the end of a seemingly ordinary shift, strange things begin to happen in the facility. Leaving won't be easy as the keys required for the exit doors have been misplaced.</p><p><strong>Development</strong></p><p>This was my first Unity project I created during my time at Edmonton Digital Arts College. The project has eight weeks of development time with seldom game engine and coding experience.</p><p><strong>Developer's Note</strong></p><p>Thanks for 25,000+ Midnight Shift downloads! I appreciate all the support and your interest in my projects.</p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 150000,
					NumberOfDownloads = 150,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = true,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
					Name = "Broken Relic",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelicCoverImage.png",
					VideoLink = "https://www.youtube.com/watch?v=ColSNi0XD6Q",
					ShortDescription = "First day on the job. You broke a seal, unleashed a dark power, and may have doomed everyone.",
					Description = "<h2>THE STORY</h2><p>On your first day as an apprentice at the Nytheris Archive, you accidentally unleash an ancient force that was meant to stay sealed forever. Ooops!</p><p>Now, with the world teetering on the brink, it's up to you to piece together the remnants of a shattered relic and set things right.</p><p>Explore a world filled with strange characters, forgotten ruins, and puzzles. Follow the clues. Trust your instincts... and try not to make things worse.</p><p><em>Broken Relic</em>&nbsp;invites you to navigate a crumbling world, uncovering its secrets one strange step at a time. You may not be the hero it needs. But you're what it&rsquo;s got.</p><h2>What to expect:</h2><ul><li>Fully voiced dialogue with a world full of unusual people.</li><li>A handcrafted pixel art world filled with details and secrets.</li><li>Nonlinear exploration across connected regions.</li><li>No fail states, no pixel hunting, no filler.<br /><br /><br />If you enjoy the demo, please wishlist and follow the game on Steam, it really helps support the project!&nbsp;<br /><a href=\"https://store.steampowered.com/app/3384820/Broken_Relic/\" rel=\"nofollow noopener\">https://store.steampowered.com/app/3384820/Broken_Relic/<br /></a></li></ul><p>Also you can join the newsletter to hear about the big updates:&nbsp;<a href=\"https://broken-relic.kit.com/ea36291513\" rel=\"nofollow noopener\">https://www.brokenrelic.com/<br /></a>And dont forget to join our Discord!! <a href=\"https://discord.gg/zDBJUKwD\" rel=\"nofollow noopener\">https://discord.gg/zDBJUKwD</a></p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 200000,
					NumberOfDownloads = 200,
					CreatedAt = DateTime.Now,
					AverageSession = 3.0,
					AllowDonation = false,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				},
				new Games
				{
					Id = Guid.Parse("b2fd90a7-5714-489e-b952-31b59a058db1"),
					Name = "Moldwasher",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/MoldwasherCoverImage.png",
					VideoLink = "https://www.youtube.com/watch?v=6KGgPoY7TbY",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 120000,
					NumberOfDownloads = 250,
					CreatedAt = DateTime.Now,
					AverageSession = 1.0,
					AllowDonation = true,
					CategoryId = Guid.Parse("7a03afa3-2635-43bd-a58c-daeb80d3cef7"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("0f78b4ed-b351-4517-89fc-a05f07570e44"),
					Name = "Latestop",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/MoldwasherCoverImage.png",
					VideoLink = "https://www.youtube.com/watch?v=WJKp2xT4QTs",
					ShortDescription = "Chill mold-cleaning arcade",
					Description = "<h2>THE STORY</h2><p>On your first day as an apprentice at the Nytheris Archive, you accidentally unleash an ancient force that was meant to stay sealed forever. Ooops!</p><p>Now, with the world teetering on the brink, it's up to you to piece together the remnants of a shattered relic and set things right.</p><p>Explore a world filled with strange characters, forgotten ruins, and puzzles. Follow the clues. Trust your instincts... and try not to make things worse.</p><p><em>Broken Relic</em>&nbsp;invites you to navigate a crumbling world, uncovering its secrets one strange step at a time. You may not be the hero it needs. But you're what it&rsquo;s got.</p><h2>What to expect:</h2><ul><li>Fully voiced dialogue with a world full of unusual people.</li><li>A handcrafted pixel art world filled with details and secrets.</li><li>Nonlinear exploration across connected regions.</li><li>No fail states, no pixel hunting, no filler.<br /><br /><br />If you enjoy the demo, please wishlist and follow the game on Steam, it really helps support the project!&nbsp;<br /><a href=\"https://store.steampowered.com/app/3384820/Broken_Relic/\" rel=\"nofollow noopener\">https://store.steampowered.com/app/3384820/Broken_Relic/<br /></a></li></ul><p>Also you can join the newsletter to hear about the big updates:&nbsp;<a href=\"https://broken-relic.kit.com/ea36291513\" rel=\"nofollow noopener\">https://www.brokenrelic.com/<br /></a>And dont forget to join our Discord!!&nbsp;<a href=\"https://discord.gg/zDBJUKwD\" rel=\"nofollow noopener\">https://discord.gg/zDBJUKwD</a></p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 100000,
					NumberOfDownloads = 300,
					CreatedAt = DateTime.Now,
					AverageSession = 1.0,
					AllowDonation = false,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("381c9309-d036-4c9a-a651-d8ebf631528e"),
					Name = "QuietPlace",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage.png",
					VideoLink = "https://www.youtube.com/watch?v=gjV5Vdf04UY&t=1s",
					ShortDescription = "Short and strange psychological horror",
					Description = "<h3>ABOUT:</h3><p>A short,&nbsp;psychological horror experience where you, player, quickly age to see how's your family doing now.</p><h3>MORE INFO:</h3><p>~10 minutes</p><p>In game font: \"MouseMemoirs\"</p><h3>CONTROLS:</h3><table><tbody><tr><td>Movement</td><td>W, A,&nbsp;S, D</td></tr><tr><td>Sprint</td><td>Shift</td></tr><tr><td>Crouch</td><td>Ctrl</td></tr><tr><td>Interaction</td><td>E</td></tr></tbody></table><h3>NOTE:</h3><p>Game has a bit of experimentation going on in it and I tried some new stuff, like moving away from retro graphics, experimenting with movement and colors etc. and I sincerely hope that you will like what you see!</p><p>If you run into any bugs or issues, feel free to reach out in the comments, my&nbsp;<a href=\"https://www.youtube.com/@VukDobric\" target=\"_blank\" rel=\"nofollow noopener\">YouTube</a>&nbsp;channel or by e-mail at&nbsp;vukkdobric@gmail.com</p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 50000,
					NumberOfDownloads = 300,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = true,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				},
				new Games
				{
					Id = Guid.Parse("f6935d98-bd02-4716-a968-3bc870e6233b"),
					Name = "Pacside",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage.png",
					VideoLink = "https://www.youtube.com/watch?v=yxt7w5VRQ_w",
					ShortDescription = "A pac-man horror game",
					Description = "<h3>Welcome to PAC-SIDE</h3><p>PAC-SIDE is a fast-paced pacman-based horror game, where you can meet your old yellow friend! Wait.. It looks like something bad&nbsp;happened with him..</p><h3>Controls</h3><table><tbody><tr><td><strong>W, A,&nbsp;S, D</strong></td><td>Movement</td></tr><tr><td><strong>Mouse</strong></td><td>Look Around</td></tr><tr><td><strong>Left Shift</strong></td><td>Run</td></tr></tbody></table><h3>Epilepsy Warning!</h3><p>This game contains flashing lights and images, which is&nbsp;<strong>NOT RECOMMENDED</strong>&nbsp;for sensitive people.</p><h3>Developer</h3><p>Game by&nbsp;<strong>SeriousDaniel</strong></p><p>Made with Unreal Engine</p><p><strong>This game is a fan-game and does NOT related to the original Pac-Man or its developers. All rights to the original characters, sounds and graphics&nbsp;belong to Bandai Namco.</strong></p><p>Follow me on X&nbsp;<a href=\"https://x.com/serious_voice\" rel=\"nofollow noopener\">https://x.com/serious_voice</a></p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 75000,
					NumberOfDownloads = 400,
					CreatedAt = DateTime.Now,
					AverageSession = 1.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("7a03afa3-2635-43bd-a58c-daeb80d3cef7"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
					Name = "Sheepy",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage.jpg",
					VideoLink = "https://www.youtube.com/watch?v=RRs_AI96h-w",
					ShortDescription = "Help Sheepy, as he explores a forgotten an broken world.",
					Description = "<h3>Help Sheepy, an abandoned plushy brought to life, as he explores a forgotten and broken world. Sheepy: A Short Adventure is the first short game from MrSuicideSheep.</h3><h2>Independently Handcrafted</h2><p>A short, handcrafted, fully independent pixel art platformer, spanning several zones with unique skills to unlock. Discover an abandoned world full of secrets and lore influenced by themes driven by the music and community of MrSuicideSheep for more than 10 years.&nbsp;</p><h2>An Original Soundtrack</h2><p>Weaved into the world is an incredible original soundtrack created by Seeking Blue artists Tal Richards, Hahlweg and Yoe Mase availble to stream and purchase here.</p><h2>Mailing List</h2><p>Join the Mailing List and be the first to learn about future happenings with Sheepy!</p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 75000,
					NumberOfDownloads = 500,
					CreatedAt = DateTime.Now,
					AverageSession = 1.5,
					AllowDonation = true,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("a670e609-db94-42b5-b196-f618e79ce15b"),
					Name = "Daughter",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage.png",
					VideoLink = "",
					ShortDescription = "A short horror game",
					Description = "<p><em>Donation is not necessary to play the game, but definitely much appreciated for me to keep making games.</em></p><p>---</p><h2><strong>DAUGHTER</strong></h2><p>Your daughter went to a sleepover birthday party at her friend's house, what could go wrong?</p><p>This is a short horror game about you trying to rescuing your daughter from a creepy house.</p><p>The story might feel incomplete as&nbsp;Daughter is a submission to the Lost Relic Games Game Jam 2022 and was made in a week. The theme is \"connection\" and I'm going for a more abstract route about the connection between the father and the daughter.</p><p>Your comments and feedbacks are very much appreciated as I might be updating this game after the Jam.</p><p>---</p><p><strong>BUGS</strong></p><ul><li>If you have a hard time reading the notes, close the flashlight before you interact with it.</li></ul><p>---</p><h2>BASIC CONTROLS</h2><p>Only support keyboard and mouse.</p><p>W,A,S,D - Walk</p><p>LEFT SHIFT - Sprint</p><p>F / E / LMB&nbsp;- Interact</p><p>G - Flashlight</p><p>Left CTRL - Crouch</p><p>---</p><p><strong>If you enjoy my game,&nbsp;you can follow my development on X:&nbsp;<a href=\"https://x.com/MikeTenDev\" rel=\"nofollow noopener\">https://x.com/MikeTenDev</a></strong></p><p>---</p><h2>CREDITS</h2><p><strong>TOOLS USED:&nbsp;</strong>Unreal Engine, Blender and Audacity</p><p><strong>ASSETS USED:</strong></p><p>Modular PSX Architecture Pack:&nbsp;<a href=\"https://comp3interactive.itch.io/modular-psx-architecture-kit\">https://comp3interactive.itch.io/modular-psx-architecture-kit</a></p><p>Retro PSX Style Tree Pack:&nbsp;<a href=\"https://elegantcrow.itch.io/psx-retro-style-tree-pack\">https://elegantcrow.itch.io/psx-retro-style-tree-pack</a></p><p>Retro House Pack: <a href=\"https://elegantcrow.itch.io/retro-house-pack\">https://elegantcrow.itch.io/retro-house-pack</a></p><p>Tiny Texture Pack 1:&nbsp;<a href=\"https://screamingbrainstudios.itch.io/tiny-texture-pack\">https://screamingbrainstudios.itch.io/tiny-texture-pack</a></p><p>Deceitful Castle in Dungeon Music Pack:&nbsp;<a href=\"https://assetstore.unity.com/packages/audio/music/dungeon-music-pack-20599\" rel=\"nofollow noopener\">https://assetstore.unity.com/packages/audio/music/dungeon-music-pack-20599</a></p><p>Fantasy Sound Bundle:&nbsp;<a href=\"https://assetstore.unity.com/packages/audio/sound-fx/fantasy-sounds-bundle-193760\" rel=\"nofollow noopener\">https://assetstore.unity.com/packages/audio/sound-fx/fantasy-sounds-bundle-19376</a></p><p>Happy Birthday Whistle:&nbsp;<a href=\"https://freesound.org/people/gaiterjay/sounds/617576/\" rel=\"nofollow noopener\">https://freesound.org/people/gaiterjay/sounds/617576/</a></p><p>Requiem in d minor:&nbsp;<a href=\"https://musopen.org/music/43683-requiem-in-d-minor-k-626/\" rel=\"nofollow noopener\">https://musopen.org/music/43683-requiem-in-d-minor-k-626/</a></p><p>Biblical Goth Girl:&nbsp;<a href=\"https://crimsongcat.itch.io/biblical-goth-angel-girl\">https://crimsongcat.itch.io/biblical-goth-angel-girl</a></p><p>Brush Strokes:&nbsp;<a href=\"https://www.freepik.com/vectors/japanese-brush\" rel=\"nofollow noopener\">https://www.freepik.com/vectors/japanese-brush</a></p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 75000,
					NumberOfDownloads = 200,
					CreatedAt = DateTime.Now,
					AverageSession = 1,
					AllowDonation = false,
					CategoryId = Guid.Parse("2d740ce2-a803-4b32-8df8-ab5139203742"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				},
				new Games
				{
					Id = Guid.Parse("8dd6053e-f3b1-4019-8898-668208f4dd31"),
					Name = "Missing",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage.png",
					VideoLink = "",
					ShortDescription = "Your friend's gone missing. You're out to find out what happened to them.",
					Description = "<p>a short&nbsp;<strong>vn style game</strong>&nbsp;made in rpgmaker in which you try to find out what happened to your missing friend.</p><p><strong>contains: mild blood, needles, a yandere, and a little bit of comedy</strong></p><p>this game's super short,&nbsp;<strong>5 endings</strong>, maybe around 10 to 15 minutes to complete?</p><p>sorry if there's errors and stuff, i made the entire thing in one night and im very sleep deprived&nbsp;</p><p>if there's any major errors or bugs lmk i'll try to get to fixing that asap okay dokay</p><p><strong>credits</strong></p><p>art and music: me</p><p>plugins: galv and that YEP message core thingy</p><p><strong>and btw.....!</strong></p><p>if you wanna follow along the development of the main game that this one is based off of, come&nbsp;<a href=\"https://discord.gg/MGzVp9JSsK\" target=\"_blank\" rel=\"nofollow noopener\">join my discord server!!</a></p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 60000,
					NumberOfDownloads = 150,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = true,
					CategoryId = Guid.Parse("77c89b32-78e3-4fea-915f-4b8df819ffa2"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
					Name = "Bloodmall",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage.png",
					VideoLink = "https://www.youtube.com/watch?v=1fYf3Rt7guw",
					ShortDescription = "It came without warning. Put an end to the massacre, and hunt down the dinosaur.",
					Description = "<p><em>Warning: Contains blood, violence, strong language and disturbing imagery.</em></p><h1><em>Dated November 4th, 1988.</em></h1><h2>MASSACRE AT DAYTON COUNTY MALL! HUNDREDS DEAD, OVER 350 INJURED.</h2><h2>EXPERTS ARE STILL INVESTIGATING WHAT EXACTLY HAPPENED, BUT IT APPEARS A... DINOSAUR?... MATERIALISED IN THE MALL AND WENT FERAL...</h2><p><em>This is a breaking story - more information soon.</em></p><p><strong>Special thanks:</strong></p><ul><li>3D Art assistance - Anders Brynildsen</li></ul><p><strong>Voicing:</strong></p><ul><li>Han Davies</li><li>Ned Sanders</li><li>Will Aryitey</li><li>Figerox Studios</li></ul><p>This game was heavily inspired by the legend,&nbsp;Puppet Combo.</p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 80000,
					NumberOfDownloads = 350,
					CreatedAt = DateTime.Now,
					AverageSession = 2.0,
					AllowDonation = true,
					CategoryId = Guid.Parse("7a03afa3-2635-43bd-a58c-daeb80d3cef7"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("34209460-1478-4545-9f15-723eeefc5697"),
					Name = "Thunderhead",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage.png",
					VideoLink = "https://www.youtube.com/watch?v=c8JdCXw4l3k",
					ShortDescription = "A Milk-Delivery Western Horror.",
					Description = "<p><strong><em>On Friday night, just past midnight, the people of Thunderhead screamed in terror.</em></strong></p><p><strong><em>Their end began four days earlier, when a strange hill appeared at the edge of the cemetery.</em></strong></p><p><strong><em>Maybe it began even further back - but our story begins the next morning, when the first light touched a town stained by horror.</em></strong></p><p><strong><em>What happened in Thunderhead was first told by the man who delivers milk every Friday to towns too quiet to matter.</em></strong></p><h2>FEATURES</h2><ul><li><strong><em>A&nbsp;Milk-Delivery Western Horror!</em></strong></li><li><em><strong>Driving!&nbsp;</strong></em>Take the wheel of your rusty old van.</li><li><strong><em>Delivering!</em></strong>&nbsp;Bring milk and orange juice to a tiny, forgotten Western town.<em><br /></em></li><li><strong><em>Fixing!</em></strong>&nbsp;The van's temperamental&mdash;sometimes it needs a whack with a wrench.</li><li><strong><em>Mystery!&nbsp;</em></strong>The town is empty. Where did everyone go? Why are there crosses everywhere? Who left behind those torn clothes? What happened here?</li><li><strong><em>Spectacle!</em></strong>&nbsp;Phenomenal music by&nbsp;<a href=\"https://voltzsupreme.itch.io/\">Voltz Supreme</a>, immersive sound design and an epic, cinematic finale.</li><li><strong><em>Retro graphics!</em></strong>&nbsp;Soak in the PSX-style aesthetic - on the prairie!</li></ul><h2>SOUNDTRACK</h2><p><a href=\"https://open.spotify.com/playlist/4ZiuqrgseeMUVCzz7oZI1D?si=42f92c241bdb4c7f&amp;nd=1&amp;dlsi=acab8f98a54b45e5\" rel=\"nofollow noopener\">You can listen to the soundtrack here.</a></p><h2>FOUND A BUG?&nbsp;</h2><p>Please let me know in the comments.&nbsp;</p><h2>FOLLOW ME</h2><table><tbody><tr><td><a href=\"https://bsky.app/profile/roawrvideostore.bsky.social\" rel=\"nofollow noopener\">Bluesky</a></td><td><a href=\"https://www.instagram.com/roawrvideostore/\" rel=\"nofollow noopener\">Instagram</a></td><td><a href=\"https://www.threads.net/@roawrvideostore\" rel=\"nofollow noopener\">Threads</a></td></tr></tbody></table>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 90000,
					NumberOfDownloads = 400,
					CreatedAt = DateTime.Now,
					AverageSession = 1.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				},
				new Games
				{
					Id = Guid.Parse("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
					Name = "Evaluation",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage.png",
					VideoLink = "",
					ShortDescription = "A short PS1-inspired third person adventure & exploration game about growth",
					Description = "<h1>Evaluation</h1><p>A short PS1-inspired third person adventure game about growing up&nbsp;and finding your place in reality.<br />The game focuses on rewarding exploration, features NPCs and platforming elements, all supported by the narrative and a strong eerie atmosphere.</p><p>Evaluation is my first game&nbsp;project. It was a wild ride, way longer to finalize than I expected, but I learnt so much along the way, and hope to do more in the future!</p><h1>Controls</h1><p>WASD/Arrow keys - Move<br />MOUSE - Look around /&nbsp;click advances dialogue<br />SPACE - Jump<br />E - Talk/Interact<br />ESCAPE - Skip Cutscene<br />R - Respawn (if you get stuck)</p><h1>Credits</h1><p>I crafted as much as I could do from scratch, however the following external assets were of invaluable help on pulling off the game as I imagined it:<br /><a href=\"https://hutonggames.com/\" rel=\"nofollow noopener\">Playmaker - Huton Games</a><br /><a href=\"https://www.w3schools.com/\" rel=\"nofollow noopener\">PSX Effects - Triple Axis</a><br /><a href=\"https://assetstore.unity.com/packages/tools/physics/character-movement-fundamentals-144966\" rel=\"nofollow noopener\">Character Movement Fundamentals - Jan OTT</a><br /><a href=\"https://assetstore.unity.com/packages/3d/animations/basic-motions-free-154271\" rel=\"nofollow noopener\">Basic Motions - Kevin Iglesias</a></p><h1>More</h1><p>Find me on&nbsp;<a href=\"https://www.instagram.com/vivivivitotototo/\" rel=\"nofollow noopener\">Instagram</a>,&nbsp;<a href=\"https://twitter.com/vtrmrl\" rel=\"nofollow noopener\">Twitter</a>,&nbsp;<a href=\"https://soundcloud.com/zerocrossingpoint\" rel=\"nofollow noopener\">Soundcloud</a></p><p>Let me know if you find any bugs!</p><p><br /><br /></p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 90000,
					NumberOfDownloads = 500,
					CreatedAt = DateTime.Now,
					AverageSession = 1.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("77c89b32-78e3-4fea-915f-4b8df819ffa2"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
					Name = "Dominoid",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage.png",
					VideoLink = "",
					ShortDescription = "An arcade-styled falling block puzzle game. Stack DOMINIDS, form RINGS, build COMBOS, & earn EXP to LEVEL UP!",
					Description = "<p><strong>DOMINOID&nbsp;</strong>is an arcade-styled&nbsp;puzzle game about stacking dominids!&nbsp;<strong>CLEAR&nbsp;</strong>pieces by forming&nbsp;<strong>RINGS&nbsp;</strong>with matching tiles. Create huge&nbsp;<strong>COMBOS&nbsp;</strong>by stacking dominids effectively. Collect&nbsp;<strong>BADGES&nbsp;</strong>for major accomplishments.&nbsp;Earn&nbsp;<strong>EXP&nbsp;</strong>by clearing dominids to go towards a&nbsp;<strong>LEVEL UP</strong>. Can you get all the way to&nbsp;<strong>LEVEL 10</strong>?</p><p>The game features gamepad support as well as remappable controls for both keyboard and gamepad. There's support for custom music packs, sound effect packs, background sets, and pieces. Multiple sets of backgrounds and pieces come included with the game. The game also comes with an&nbsp;instruction book and wallpaper bundle.</p><p><img src=\"https://img.itch.zone/aW1nLzIxNDg1MzM4LnBuZw==/original/TVLouX.png\" alt=\"\" /></p><p>Additional art by : Julian</p><p>Audio by : Dim&nbsp;Widdy</p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 95000,
					NumberOfDownloads = 600,
					CreatedAt = DateTime.Now,
					AverageSession = 1.0,
					AllowDonation = true,
					CategoryId = Guid.Parse("bca8721b-c323-44a1-afcf-876e206ab035"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
					Name = "DiggingHour",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage.png",
					VideoLink = "https://www.youtube.com/watch?v=tNoPejgMaB0",
					ShortDescription = "Atmospheric horror experience where you and your friend have to dig some bodies, but something is wrong.",
					Description = "<h3>ABOUT:</h3><p>A short, atmospheric horror experience where you and a friend are tasked with digging up two bodies,&nbsp;<strong>but something isn&rsquo;t right.</strong></p><h3>MORE INFO:</h3><p>~10 minutes</p><p>In game font: \"November\"</p><h3>CONTROLS:</h3><table><tbody><tr><td>Movement</td><td>W, A,&nbsp;S, D</td></tr><tr><td>Sprint</td><td>Shift</td></tr><tr><td>Interaction</td><td>E</td></tr><tr><td>Attack</td><td>LMB</td></tr></tbody></table><h3>WARNING:</h3><p>The game features mild gore, loud sound effects and everything that comes with horror genre. Player discretion is advised.</p><h3>NOTE:</h3><p>Game has a bit of comedy in it and I hope that I did good job with implementing it!</p><p>Don't harass me over voice acting :D , Neither me, or my friend are native English speakers, but we gave it our best and had a lot of fun doing it!</p><p>Most of the&nbsp;<strong>models&nbsp;</strong>(4 that aren't are aptly credited),&nbsp;<strong>music&nbsp;</strong>and&nbsp;<strong>scripts</strong>&nbsp;in&nbsp;the game are made by me, textures are from&nbsp;<a href=\"https://ambientcg.com/\" target=\"_blank\" rel=\"nofollow noopener\">AmbeintCG</a>.</p><p>If you run into any bugs or issues, feel free to reach out in the comments, my&nbsp;<a href=\"https://www.youtube.com/@VukDobric\" target=\"_blank\" rel=\"nofollow noopener\">YouTube</a>&nbsp;channel or by e-mail at&nbsp;vukkdobric@gmail.com</p><h3>UPDATE:</h3><p>CaseOh, being an absolute legend that he is, played another one of my games on his stream, this is snippet of the live where he plays this game, thanks CaseOh!</p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 85000,
					NumberOfDownloads = 700,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("2d740ce2-a803-4b32-8df8-ab5139203742"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				},
				new Games
				{
					Id = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8"),
					Name = "Dispatched",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage.png",
					VideoLink = "",
					ShortDescription = "The Hungry Hungry Hippos of late-stage capitalism.",
					Description = "<h1><em>Dispatched!&nbsp;</em></h1><h3>\"The Hungry Hungry Hippos of late-stage capitalism.\"</h3><p>From the same idiots who made 'Plane Food Simulator':&nbsp;<a href=\"https://sheepandram.itch.io/pfs2021\">https://sheepandram.itch.io/pfs2021</a></p><p><strong>Platform =</strong>&nbsp;PC and Android App&nbsp;Store<br /><strong><br /></strong><strong>Full Description:</strong></p><p>In&nbsp;<em>Dispatched!</em>&nbsp;the aim of the game is to mail as many parcels as you can within the allocated time! Be careful you don't confuse the priority boxes, and make sure you bring an empty bottle.</p><p><strong>PC Controls:<br /></strong>Begin Game: Enter<br />Dispatch Parcel (Employee Left): Q<br />Dispatch Parcel (Employee Right): P<br /><strong><br /></strong><strong>Android/Phone Controls:</strong><br />Start Game = Tap Screen<br />Dispatch Parcel&nbsp;(Employee Left) = Tap Screen (Left hand side)<br />Dispatch Parcel (Employee Right) = Tap Screen (Right hand side)<br /><strong><br /></strong></p><p><strong>Executive Imagineer Enhancement Architect</strong><br />Chris Ramsden&nbsp;<a href=\"https://chris-ramsden.neocities.org/\" rel=\"nofollow noopener\">Neocities</a><br /><strong><br /></strong><strong>Executive Code Architect and Fulfilment Developer&nbsp;</strong><br />Sheps&nbsp;<a href=\"https://linktr.ee/thesheps\" rel=\"nofollow noopener\">https://linktr.ee/thesheps</a></p><p><strong>Executive Experience Enhancement Officer&nbsp;</strong><br />Max Blake</p><p><strong>Soundtrack Specialist</strong><br />The Gasman <a href=\"https://thegasman.bandcamp.com/music\" rel=\"nofollow noopener\">https://thegasman.bandcamp.com/music</a></p><p><strong>Special Thanks&nbsp;</strong>:&nbsp;<a href=\"https://freetousesounds.bandcamp.com/\" rel=\"nofollow noopener\">https://freetousesounds.bandcamp.com/</a></p><p><strong>All essential workers and distribution staff. Thanks for halting the societal collapse of 2020/21!</strong></p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 85000,
					NumberOfDownloads = 100,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("2d740ce2-a803-4b32-8df8-ab5139203742"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
					Name = "SecurityBooth",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage.png",
					VideoLink = "https://www.youtube.com/watch?v=wYnJD9Pteis",
					ShortDescription = "A Short VHS PSX Horror Game.",
					Description = "<p><strong>Security Booth is a VHS PSX Horror Game.&nbsp;</strong></p><p>Based in 1996, you are working for a company known as Nova Nexus, you play as a security guard.<br />Your job role is to make sure that only the right authorized personnel are getting into the facility.&nbsp;</p><p>The game has a total of&nbsp;<strong>2 endings.<br /></strong></p><p><strong>Average Game Time - 10 Minutes&nbsp;</strong></p><p><strong>Game Controls&nbsp;</strong></p><table><tbody><tr><td>Walk</td><td>Look Around</td><td>Interact</td><td>FlashLight</td></tr><tr><td>W,A,S,D</td><td>Mouse</td><td>E</td><td>F</td></tr></tbody></table><p><strong>Menu/UI Controls</strong></p><table><tbody><tr><td>Select Option</td><td>Go To Option Right/Next Page</td><td>Go To Option Left/Previous Page</td><td>Go To Option Up Or Down</td></tr><tr><td>E</td><td>D</td><td>A</td><td>W - UP<br />S - Down</td></tr></tbody></table><p>*The Mouse will never show up in game*</p><p>--------------------------------------------------------------------</p><p>Want more?<br />Security Booth:&nbsp;Director's Cut is OUT NOW!<br />Check out the Steam store or grab it here on Itch.io.</p><p>Follow my twitter for future games that I am making.<br /><a href=\"https://twitter.com/KyleHorwood\" rel=\"nofollow noopener\">https://twitter.com/KyleHorwood</a></p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 70000,
					NumberOfDownloads = 200,
					CreatedAt = DateTime.Now,
					AverageSession = 1.0,
					AllowDonation = true,
					CategoryId = Guid.Parse("2d740ce2-a803-4b32-8df8-ab5139203742"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("152e3482-be53-44db-93e6-785823f6224e"),
					Name = "Atlyss",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage.png",
					VideoLink = "https://www.youtube.com/watch?v=example",
					ShortDescription = "",
					Description = "<h2>``ATLYSS``</h2><h4>SOLO DEVELOPMENT ACTION ORPG PROJECT</h4><p><em><strong>A work in progress / under development game made by Kiseff</strong></em><em><br /></em></p><h4>Core Game Info</h4><ul><li>\"ATLYSS\" is a (Single-player + Multi-player)&nbsp;<strong>A</strong>ction&nbsp;<strong>O</strong>nline&nbsp;<strong>R</strong>ole&nbsp;<strong>P</strong>laying&nbsp;<strong>G</strong>ame</li><li>Enriched, instanced maps to discover</li><li>Equipment, Trade Items and Consumables to collect</li><li>Many Character Customization options with&nbsp;<strong>5 races</strong>&nbsp;to choose from</li><li>3 Primary Classes to become at lv-10 (<strong>Fighter</strong>,&nbsp;<strong>Bandit</strong>,&nbsp;<strong>Mystic</strong>)</li><li>Skill load-out system for making builds to suit your game-play style</li><li>Character stat progression / leveling systems / attributes</li><li>7 Weapon types to use in combat (Katars, Heavy Melee, Scepters, and more)</li><li>Repeatable Questing / Single Quests to complete</li><li><strong>Aesthetics inspired by 6th Generation video games</strong></li></ul><h4>Media / Promotion</h4><p><a href=\"https://www.patreon.com/Kiseff?fan_landing=true\" target=\"_blank\" rel=\"nofollow noopener\"><strong>If you'd like to support my game-dev work and other assorted projects, you can do so via my Patreon!</strong></a></p><p>For more instant information / updates / development progress, you can:</p><p><a href=\"https://twitter.com/kis_soft\" target=\"_blank\" rel=\"nofollow noopener\"><strong>Follow @kis_soft on Twitter</strong></a><strong><br /></strong></p><p><strong><a href=\"https://discord.gg/vScP5yUbtk\" target=\"_blank\" rel=\"nofollow noopener\">Join the KisSoft Underground Server to receive progression updates and notes, including announcements first hand! Community links are provided in the Discord's promotional links channel.</a></strong></p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 60000,
					NumberOfDownloads = 150,
					CreatedAt = DateTime.Now,
					AverageSession = 1.0,
					AllowDonation = true,
					CategoryId = Guid.Parse("89a4e6d2-2cfe-4474-9b96-6d3595ad4705"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				},
				new Games
				{
					Id = Guid.Parse("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
					Name = "Tomato",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage.jpg",
					VideoLink = "",
					ShortDescription = "Welcome to my game, buddy!",
					Description = "<h4>\"Welcome to my game, buddy!\"</h4><p>Mr. TomatoS is glad to see you! He waited a long time for someone to visit him! Feel like at home and get ready for endless f̶u̶n̶ !</p><p>Mr. TomatoS needs YOUR help! looks like he had not eaten for ages! Of course not, he has no hands!</p><p>Feed Mr. Tomatos with big variety of food, combine it with blender, and use different items to help you with this task!</p><h4>\"But why should I do this?\"</h4><p>Glad you asked! By helping him you can earn a lot of points to spend them in the shop later! Everyone loves to earn points, right?</p><h4>\"Why am i always d̶y̶i̶n̶g̶ losing?\"</h4><p>Glad you asked, my dear friend! j̶u̶s̶t̶ d̶o̶n̶t̶ d̶o̶w̶n̶l̶o̶a̶d̶ i̶t̶ you need a strategy to finish the game! without a strategy, everything can go wrong.</p><p>Manage your resources correctly to s̶t̶a̶y̶ a̶l̶i̶v̶e̶ win!)</p><p>unless you want to make Mr. TomatoS angry.</p><p>This game is made in the style of old web flash games, what sets it apart from other new games!</p><p>Feel the atmosphere of old flash games!</p><p>You can complete the game only ONCE, that means that you won't have a second chance. And how you will complete YOUR game - depends only on YOU. Try your best. Good luck.</p><p>Main theme by:&nbsp;<strong>Cnupoc (</strong><span title=\"https://freesound.org/people/Cnupoc/\"><a href=\"https://freesound.org/people/Cnupoc/\" rel=\"nofollow noopener\">https://freesound.org/people/Cnupoc/</a></span><strong>)</strong></p><p>Game theme by:&nbsp;<strong>Sirkoto51 (</strong><span title=\"https://freesound.org/people/Sirkoto51/\"><a href=\"https://freesound.org/people/Sirkoto51/\" rel=\"nofollow noopener\">https://freesound.org/people/Sirkoto51/</a></span><strong>)</strong></p><p><strong>Sirkoto51 soundcloud :&nbsp;</strong>&nbsp;<span title=\"https://soundcloud.com/sirkoto51\"><a href=\"https://soundcloud.com/sirkoto51\" rel=\"nofollow noopener\">https://soundcloud.com/sirkoto51</a></span></p><p>Some sounds by:&nbsp;<strong>InspectorJ(</strong>Jonathan Shaw<strong>) (</strong><span title=\"https://freesound.org/people/InspectorJ/\"><a href=\"https://freesound.org/people/InspectorJ/\" rel=\"nofollow noopener\">https://freesound.org/people/InspectorJ/</a></span><strong>)</strong></p><p><strong>InspectorJ patreon:&nbsp;</strong><span title=\"https://www.patreon.com/JonathanShaw\"><a href=\"https://www.patreon.com/JonathanShaw\" rel=\"nofollow noopener\">https://www.patreon.com/JonathanShaw</a></span></p><h3>MrTomatoS</h3><p>- standard version of the game.</p><h3>MrTomatoS++</h3><h4>\" Oh oh, it looks like someone messed up the game code!&nbsp;\"</h4><p>- Now you can reset your game progress after completion to get more endings</p><p>- You can download this version even if you already played in standart version, and completed it</p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					NumberOfDownloads = 300,
					Price = 75000,
					CreatedAt = DateTime.Now,
					AverageSession = 1.5,
					AllowDonation = true,
					CategoryId = Guid.Parse("5e1afbc9-31dd-417d-ae49-baa45d6d5797"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
				},
				new Games
				{
					Id = Guid.Parse("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
					Name = "Leftovers",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage.png",
					VideoLink = "",
					ShortDescription = "Don't talk to strangers, unless your mother needs you to.",
					Description = "<p>Your mum is cooking dinner. Saddened by the amount of leftover and not wanting it to go to waste, she tasked you the job to give it all away to your neighbours.</p><p>You, who was just minding your own business watching cartoons. You who your mum have told many times to not talk to strangers. But yet, you have no right to deny the request.&nbsp;</p><p>Armed with limited skills of communication, meet all the quirky and creepy neighbours to finish the task before your mum finish you first...literally.</p><p>Created for SCREAM JAM 2021&nbsp;by:</p><ul><li>Realmpact - Programmer</li><li>Skekarin - Artist, Writer and Games Designer</li></ul><p><strong>Disclaimer</strong></p><p>The WebGL version of the game is meant for users who are not using a Windows machine. For the best experience, we would recommend downloading the Windows version instead.</p><p>FAQ</p><ul><li>Help! I cannot show the leftovers!<ul><li>Press Q during the prompt to show leftovers&nbsp;to continue the conversation as if you showed it.</li></ul></li></ul>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 50000,
					NumberOfDownloads = 100,
					CreatedAt = DateTime.Now,
					AverageSession = 0.5,
					AllowDonation = false,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
				},
				new Games
				{
					Id = Guid.Parse("791a4c74-d469-4432-bd76-c5ace021ce8e"),
					Name = "TheStation",
					CoverImage = "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage.png",
					VideoLink = "",
					ShortDescription = "Just a typical subway ride...",
					Description = "<p>After a long day, you take the subway home. The train is late, but everything seems normal&mdash;until the doors close. Among the passengers, one man starts acting strange... There's nowhere to run.</p><h3>Features:</h3><p>Average playtime: 5&ndash;10 minutes</p><p>Four original endings + secret ending</p><p>PSX retro style</p><p>Original story</p><p><strong>Streamer-YouTuber friendly: non-copyright music</strong></p><p>Completely translated to Portuguese, Spanish, Turkish, Polish, Russian, German, Korean, Italian and French!</p><h3>Controls:</h3><p>Movement: WASD</p><p>Run: Shift</p><p>Interact: E</p><p>Next dialogue/Move objects: Left mouse button</p><p>Stand up: Space</p><h3>About:</h3><p>DISCLAIMER: This game displays your pc's name so if you don't want your real name to be displayed you should change your pc's name or just don't play the game on stream.</p><p>If you liked this game, you should check out:</p><p><a href=\"https://riversoftware.itch.io/on-my-way-home\">On My Way Home by RiverSoftware</a></p><p><a href=\"https://riversoftware.itch.io/neighbournextdoor\">Neighbour Next Door by RiverSoftware</a></p><p><a href=\"https://riversoftware.itch.io/tv-night\">TV Night by RiverSoftware</a></p><h3>Known Issues:</h3><p>Gameplay limited to 100fps due to a bug with player controller</p><p>Some lights may not work if you select the low graphics option</p>",
					Status = GameStatus.Released,
					Visibility = GameVisibility.Public,
					CensorStatus = CensorStatus.Approved,
					Price = 65000,
					NumberOfDownloads = 200,
					CreatedAt = DateTime.Now,
					AverageSession = 1.0,
					AllowDonation = true,
					CategoryId = Guid.Parse("dfeeb47a-7e69-4927-a65b-b803a8befe9f"),
					AgeRestrictionId = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					DeveloperId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
				}
			);
		}
	}
}
