using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class NotificationConfiguration : IEntityTypeConfiguration<Notifications>
	{
		public void Configure(EntityTypeBuilder<Notifications> builder)
		{
			builder.HasKey(n => n.Id);
			builder.Property(n => n.Message);
			builder.Property(n => n.CreatedAt);
			builder.Property(n => n.ReadAt);
			builder.Property(n => n.IsRead);
			builder.HasOne(n => n.User)
				.WithMany(u => u.Notifications)
				.HasForeignKey(n => n.UserId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
