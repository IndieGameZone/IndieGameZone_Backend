using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class ReportConfiguration : IEntityTypeConfiguration<Reports>
	{
		public void Configure(EntityTypeBuilder<Reports> builder)
		{
			builder.HasKey(r => r.Id);
			builder.Property(r => r.Message);
			builder.Property(r => r.CreatedAt);

			builder.HasOne(r => r.ReportingUser)
				.WithMany(u => u.ReportingUsers)
				.HasForeignKey(r => r.ReportingUserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(r => r.ReportedUser)
				.WithMany(u => u.ReportedUsers)
				.HasForeignKey(r => r.ReportedUserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(r => r.ReportType)
				.WithMany(rt => rt.Reports)
				.HasForeignKey(r => r.ReportTypeId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(r => r.Post)
				.WithMany(p => p.Reports)
				.HasForeignKey(r => r.PostId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(r => r.Game)
				.WithMany(g => g.Reports)
				.HasForeignKey(r => r.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(r => r.PostComment)
				.WithMany(c => c.Reports)
				.HasForeignKey(r => r.CommentId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
