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
				.OnDelete(DeleteBehavior.Restrict);

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
				},
				new Wallets
				{
					UserId = Guid.Parse("23879117-e09e-40f1-b78f-1493d81baf49"),
					Balance = 0.0,
				},
				new Wallets
				{
					UserId = Guid.Parse("91b106fa-7b95-480f-a12a-0e0303454332"),
					Balance = 0.0,
				},
				new Wallets
				{
					UserId = Guid.Parse("537f05fd-120c-40b0-b2ec-639756f866ab"),
					Balance = 0.0,
				},
				new Wallets
				{
					UserId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f"),
					Balance = 0.0,
				},
				new Wallets
				{
					UserId = Guid.Parse("34670beb-a794-4419-adf8-0465eea22a78"),
					Balance = 0.0,
				},
				new Wallets
				{
					UserId = Guid.Parse("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
					Balance = 0.0,
				}
			);
		}
	}
}
