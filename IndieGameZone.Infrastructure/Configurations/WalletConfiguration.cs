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
		}
	}
}
