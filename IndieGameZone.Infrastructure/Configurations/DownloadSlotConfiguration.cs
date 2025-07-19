using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class DownloadSlotConfiguration : IEntityTypeConfiguration<DownloadSlots>
	{
		public DownloadSlotConfiguration()
		{
		}

		public void Configure(EntityTypeBuilder<DownloadSlots> builder)
		{
			builder.HasKey(ds => ds.Id);
			builder.Property(ds => ds.DownloadAt);
			builder.HasOne(ds => ds.Game)
				.WithMany(g => g.DownloadSlots)
				.HasForeignKey(ds => ds.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(ds => ds.User)
				.WithMany(u => u.DownloadSlots)
				.HasForeignKey(ds => ds.UserId)
				.OnDelete(DeleteBehavior.Restrict);

		}
	}
}
