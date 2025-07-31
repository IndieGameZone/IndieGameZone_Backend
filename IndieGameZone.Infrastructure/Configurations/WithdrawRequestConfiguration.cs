using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class WithdrawRequestConfiguration : IEntityTypeConfiguration<WithdrawRequests>
	{
		public void Configure(EntityTypeBuilder<WithdrawRequests> builder)
		{
			builder.HasKey(w => w.Id);
			builder.Property(w => w.ImageProof);
			builder.Property(w => w.Amount);
			builder.Property(w => w.Status).HasConversion<string>().HasMaxLength(10);
			builder.Property(w => w.HandledAt);
			builder.Property(w => w.CreatedAt);
			builder.Property(w => w.RejectReason);

			builder.HasOne(w => w.User)
				.WithMany(u => u.WithdrawRequests)
				.HasForeignKey(w => w.UserId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
