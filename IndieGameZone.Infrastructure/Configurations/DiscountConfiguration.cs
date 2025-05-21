using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class DiscountConfiguration : IEntityTypeConfiguration<Discounts>
	{
		public void Configure(EntityTypeBuilder<Discounts> builder)
		{
			builder.HasKey(d => d.Id);
			builder.Property(d => d.Percentage);
			builder.Property(d => d.StartDate);
			builder.Property(d => d.EndDate);

			builder.HasOne(d => d.Game)
				.WithMany(g => g.Discounts)
				.HasForeignKey(d => d.GameId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
