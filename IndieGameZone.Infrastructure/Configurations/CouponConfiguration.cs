using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class CouponConfiguration : IEntityTypeConfiguration<Coupons>
	{
		public void Configure(EntityTypeBuilder<Coupons> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Code).HasMaxLength(10);
			builder.HasIndex(c => c.Code).IsUnique();
			builder.Property(c => c.Percentage);
			builder.Property(c => c.IsUsed);
			builder.Property(c => c.EndDate);

			builder.HasOne(c => c.User)
				.WithMany(u => u.Coupons)
				.HasForeignKey(c => c.UserId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
