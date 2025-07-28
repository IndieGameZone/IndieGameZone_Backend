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
			builder.Property(t => t.Type).HasConversion<string>().HasMaxLength(50);
			builder.Property(t => t.CreatedAt);

			builder.HasOne(t => t.User)
				.WithMany(u => u.Transactions)
				.HasForeignKey(t => t.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(t => t.Game)
				.WithMany(g => g.Transactions)
				.HasForeignKey(t => t.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(t => t.PurchaseUser)
				.WithMany(u => u.PurchaseTransactions)
				.HasForeignKey(t => t.PurchaseUserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(t => t.Order)
				.WithOne(o => o.Transaction)
				.HasForeignKey<Transactions>(t => t.OrderId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
