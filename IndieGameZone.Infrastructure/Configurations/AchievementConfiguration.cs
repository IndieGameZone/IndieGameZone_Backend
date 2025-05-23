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
		}
	}
}
