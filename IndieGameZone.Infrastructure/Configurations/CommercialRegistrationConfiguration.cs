using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class CommercialRegistrationConfiguration : IEntityTypeConfiguration<CommercialRegistrations>
	{
		public void Configure(EntityTypeBuilder<CommercialRegistrations> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.StartDate);
			builder.Property(c => c.EndDate);
            builder.Property(c => c.CreatedAt);
            builder.Property(c => c.Status).HasConversion<string>().HasMaxLength(20);

            builder.HasOne(c => c.Game)
				.WithMany(c => c.CommercialRegistrations)
				.HasForeignKey(c => c.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(c => c.CommercialPackage)
				.WithMany(c => c.CommercialRegistrations)
				.HasForeignKey(c => c.CommercialPackageId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
