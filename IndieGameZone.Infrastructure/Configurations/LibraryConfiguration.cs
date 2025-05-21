using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class LibraryConfiguration : IEntityTypeConfiguration<Libraries>
	{
		public void Configure(EntityTypeBuilder<Libraries> builder)
		{
			builder.HasKey(l => new { l.UserId, l.GameId });
			builder.Property(l => l.PurchasedAt);

			builder.HasOne(l => l.Game)
				.WithMany(g => g.Libraries)
				.HasForeignKey(l => l.GameId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(l => l.User)
				.WithMany(u => u.Libraries)
				.HasForeignKey(l => l.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
