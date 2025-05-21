using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class WalletConfiguration : IEntityTypeConfiguration<Wallets>
	{
		public void Configure(EntityTypeBuilder<Wallets> builder)
		{
			builder.HasKey(w => w.UserId);
			builder.Property(w => w.Balance);

			builder.HasOne(w => w.User)
				.WithOne(u => u.Wallet)
				.HasForeignKey<Wallets>(w => w.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
