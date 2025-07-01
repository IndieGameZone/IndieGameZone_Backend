using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class CommercialRegistrationConfiguration : IEntityTypeConfiguration<CommercialRegistration>
	{
		public void Configure(EntityTypeBuilder<CommercialRegistration> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.StartDate);
			builder.Property(c => c.EndDate);

			builder.HasOne(c => c.Game)
				.WithMany(c => c.CommercialRegistrations)
				.HasForeignKey(c => c.GameId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(c => c.CommercialPackage)
				.WithMany(c => c.CommercialRegistrations)
				.HasForeignKey(c => c.CommercialPackageId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(c => c.Transaction)
				.WithOne(t => t.CommercialRegistration)
				.HasForeignKey<CommercialRegistration>(c => c.TransactionId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
