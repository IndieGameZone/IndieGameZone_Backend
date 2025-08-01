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
			builder.Property(r => r.Status)
                .HasConversion<string>()
                .IsRequired();
			builder.Property(r => r.ReviewMessage);

            builder.HasOne(r => r.ReportingUser)
				.WithMany(u => u.ReportingUsers)
				.HasForeignKey(r => r.ReportingUserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(r => r.ReportReason)
				.WithMany(rt => rt.Reports)
				.HasForeignKey(r => r.ReportReasonId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(r => r.Post)
				.WithMany(p => p.Reports)
				.HasForeignKey(r => r.PostId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(r => r.Game)
				.WithMany(g => g.Reports)
				.HasForeignKey(r => r.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(r => r.PostComment)
				.WithMany(c => c.Reports)
				.HasForeignKey(r => r.CommentId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
