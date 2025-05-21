using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class AgeRestrictionConfiguration : IEntityTypeConfiguration<AgeRestrictions>
	{
		public void Configure(EntityTypeBuilder<AgeRestrictions> builder)
		{
			builder.HasKey(a => a.Id);
			builder.Property(a => a.Code).HasMaxLength(10);
			builder.Property(a => a.Description).HasMaxLength(100);

			builder.HasMany(a => a.Games)
				.WithOne(g => g.AgeRestriction)
				.HasForeignKey(g => g.AgeRestrictionId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
