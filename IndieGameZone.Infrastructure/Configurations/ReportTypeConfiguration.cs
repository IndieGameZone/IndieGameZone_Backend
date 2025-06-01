using IndieGameZone.Domain.Constants;
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

            builder.HasData(
                new ReportTypes
                {
                    Id = Guid.Parse("77cf1c6b-bc98-4c98-8a7e-27f2c4b45377"),
                    Name = ReportTypeEnum.UserReport.ToString()
                },
                new ReportTypes
                {
                    Id = Guid.Parse("8b92d32e-0aa0-4f88-bc43-0e04c4121e0e"),
                    Name = ReportTypeEnum.PostReport.ToString()
                },
                new ReportTypes
                {
                    Id = Guid.Parse("1c0d2f16-1f4a-4c5e-9c26-2e86e0cfa28f"),
                    Name = ReportTypeEnum.GameReport.ToString()
                }
            );
        }
	}
}
