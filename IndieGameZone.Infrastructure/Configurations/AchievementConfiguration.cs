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

			builder.HasMany(a => a.Users)
				.WithMany(u => u.Achievements)
				.UsingEntity<UserAchievements>();
		}
	}
}
