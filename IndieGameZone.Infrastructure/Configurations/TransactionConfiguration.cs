using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class TransactionConfiguration : IEntityTypeConfiguration<Transactions>
	{
		public void Configure(EntityTypeBuilder<Transactions> builder)
		{
			builder.HasKey(t => t.Id);
			builder.Property(t => t.OrderCode);
			builder.HasIndex(x => x.OrderCode).IsUnique();
			builder.Property(t => t.PaymentMethod).HasConversion<string>().HasMaxLength(10);
			builder.Property(t => t.Amount);
			builder.Property(t => t.Description);
			builder.Property(t => t.Status).HasConversion<string>().HasMaxLength(10);
			builder.Property(t => t.Type).HasConversion<string>().HasMaxLength(30);
			builder.Property(t => t.CreatedAt);
			builder.Property(t => t.CommercialRegistrationStartDate);
			builder.Property(t => t.CommercialRegistrationEndDate);

			builder.HasOne(t => t.User)
				.WithMany(u => u.Transactions)
				.HasForeignKey(t => t.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(t => t.WithdrawRequest)
				.WithOne(w => w.Transaction)
				.HasForeignKey<WithdrawRequests>(w => w.TransactionId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(t => t.Game)
				.WithMany(g => g.Transactions)
				.HasForeignKey(t => t.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(t => t.CommercialPackage)
				.WithMany(c => c.Transactions)
				.HasForeignKey(t => t.CommercialPackageId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(t => t.PurchaseUser)
				.WithMany(u => u.PurchaseTransactions)
				.HasForeignKey(t => t.PurchaseUserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(t => t.Coupon)
				.WithOne(c => c.Transaction)
				.HasForeignKey<Transactions>(t => t.CouponId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
