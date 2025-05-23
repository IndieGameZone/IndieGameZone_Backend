﻿using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class UserAchievementConfiguration : IEntityTypeConfiguration<UserAchievements>
	{
		public void Configure(EntityTypeBuilder<UserAchievements> builder)
		{
			builder.HasKey(ua => new { ua.UserId, ua.AchievementId });

			builder.HasOne(ua => ua.User)
				.WithMany(u => u.UserAchievements)
				.HasForeignKey(ua => ua.UserId)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(ua => ua.Achievement)
				.WithMany(a => a.UserAchievements)
				.HasForeignKey(ua => ua.AchievementId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
