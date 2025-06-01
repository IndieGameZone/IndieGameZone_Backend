using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class WithdrawRequestConfiguration : IEntityTypeConfiguration<WithdrawRequests>
	{
		public void Configure(EntityTypeBuilder<WithdrawRequests> builder)
		{
			builder.HasKey(w => w.TransactionId);
			builder.Property(w => w.ImageProof);
			builder.Property(w => w.IsTransfered);

			builder.HasOne(w => w.Transaction)
				.WithOne(t => t.WithdrawRequest)
				.HasForeignKey<WithdrawRequests>(w => w.TransactionId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
