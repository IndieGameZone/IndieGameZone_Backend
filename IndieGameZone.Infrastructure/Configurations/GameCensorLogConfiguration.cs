using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class GameCensorLogConfiguration : IEntityTypeConfiguration<GameCensorLogs>
	{
		public void Configure(EntityTypeBuilder<GameCensorLogs> builder)
		{
			builder.HasKey(gcl => gcl.Id);
			builder.Property(gcl => gcl.CensoredAt);
			builder.Property(gcl => gcl.CensorReason);
			builder.Property(gcl => gcl.CensorStatus).HasConversion<string>().HasMaxLength(50);
			builder.HasOne(gcl => gcl.Moderator)
				.WithMany(gcl => gcl.GameCensorLogs)
				.HasForeignKey(gcl => gcl.ModeratorId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(gcl => gcl.Game)
				.WithMany(gcl => gcl.GameCensorLogs)
				.HasForeignKey(gcl => gcl.GameId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
