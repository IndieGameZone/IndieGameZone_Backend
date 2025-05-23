using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class CommercialPackageConfiguration : IEntityTypeConfiguration<CommercialPackages>
	{
		public void Configure(EntityTypeBuilder<CommercialPackages> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Name).HasMaxLength(100);
			builder.Property(c => c.Description);
			builder.Property(c => c.Duration);
			builder.Property(c => c.Price);

			builder.HasMany(c => c.CommercialRegistrations)
				.WithOne(c => c.CommercialPackage)
				.HasForeignKey(c => c.CommercialPackageId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
