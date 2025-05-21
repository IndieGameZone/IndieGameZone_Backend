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
			builder.Property(t => t.Amount);
			builder.Property(t => t.Description);
			builder.Property(t => t.Status)
				.HasConversion<string>()
				.HasMaxLength(50);
			builder.Property(t => t.Type)
				.HasConversion<string>()
				.HasMaxLength(50);
			builder.Property(t => t.CreatedAt);

			builder.HasOne(t => t.User)
				.WithMany(u => u.Transactions)
				.HasForeignKey(t => t.UserId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(t => t.WithdrawRequest)
				.WithOne(w => w.Transaction)
				.HasForeignKey<WithdrawRequests>(w => w.TransactionId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
