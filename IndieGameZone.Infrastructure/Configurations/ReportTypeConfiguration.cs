using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class ReportTypeConfiguration : IEntityTypeConfiguration<ReportTypes>
	{
		public void Configure(EntityTypeBuilder<ReportTypes> builder)
		{
			builder.HasKey(rt => rt.Id);
			builder.Property(rt => rt.Name);

			builder.HasMany(rt => rt.Reports)
				.WithOne(r => r.ReportType)
				.HasForeignKey(r => r.ReportTypeId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
