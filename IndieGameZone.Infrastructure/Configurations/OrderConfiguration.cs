using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class OrderConfiguration : IEntityTypeConfiguration<Orders>
	{
		public void Configure(EntityTypeBuilder<Orders> builder)
		{
			builder.HasKey(o => o.Id);
			builder.Property(o => o.Amount);
			builder.Property(o => o.CommercialRegistrationEndDate);
			builder.Property(o => o.CommercialRegistrationStartDate);
			builder.Property(o => o.CreatedAt);

			builder.HasOne(o => o.User)
				.WithMany(u => u.Orders)
				.HasForeignKey(o => o.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(o => o.Game)
				.WithMany(g => g.Orders)
				.HasForeignKey(o => o.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(o => o.CommercialPackage)
				.WithMany(cp => cp.Orders)
				.HasForeignKey(o => o.CommercialPackageId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(o => o.Coupon)
				.WithOne(c => c.Order)
				.HasForeignKey<Orders>(o => o.CouponId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(o => o.Transaction)
				.WithOne(t => t.Order)
				.HasForeignKey<Transactions>(o => o.OrderId)
				.OnDelete(DeleteBehavior.Restrict);

		}
	}
}
