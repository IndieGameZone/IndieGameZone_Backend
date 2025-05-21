using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class WishlistConfiguration : IEntityTypeConfiguration<Wishlists>
	{
		public void Configure(EntityTypeBuilder<Wishlists> builder)
		{
			builder.HasKey(w => new { w.GameId, w.UserId });
			builder.Property(w => w.AddedAt);

			builder.HasOne(w => w.Game)
				.WithMany(g => g.Wishlists)
				.HasForeignKey(w => w.GameId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(w => w.User)
				.WithMany(u => u.Wishlists)
				.HasForeignKey(w => w.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
