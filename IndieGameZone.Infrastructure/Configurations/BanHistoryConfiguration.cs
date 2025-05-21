using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class BanHistoryConfiguration : IEntityTypeConfiguration<BanHistories>
	{
		public void Configure(EntityTypeBuilder<BanHistories> builder)
		{
			builder.HasKey(b => b.Id);
			builder.Property(b => b.BanDate);
			builder.Property(b => b.UnbanDate);
			builder.Property(b => b.Reason);
			builder.HasOne(builder => builder.User)
				.WithMany(user => user.BanHistories)
				.HasForeignKey(b => b.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
