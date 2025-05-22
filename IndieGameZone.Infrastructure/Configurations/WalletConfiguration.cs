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

			builder.HasData(
				new Wallets
				{
					UserId = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"),
					Balance = 0.0,
				},
				new Wallets
				{
					UserId = Guid.Parse("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
					Balance = 0.0,
				}
			);
		}
	}
}
