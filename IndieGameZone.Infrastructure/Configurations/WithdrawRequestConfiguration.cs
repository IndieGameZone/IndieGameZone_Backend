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
			builder.Property(w => w.IsTransfered);

			builder.HasOne(w => w.User)
				.WithMany(u => u.WithdrawRequests)
				.HasForeignKey(w => w.UserId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
