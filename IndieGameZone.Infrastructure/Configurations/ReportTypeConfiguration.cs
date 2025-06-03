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
					Name = "Inappropriate Content"
				},
				new ReportTypes
				{
					Id = Guid.Parse("8b92d32e-0aa0-4f88-bc43-0e04c4121e0e"),
					Name = "Copyright Infringement"
				},
				new ReportTypes
				{
					Id = Guid.Parse("1c0d2f16-1f4a-4c5e-9c26-2e86e0cfa28f"),
					Name = "Malicious Behavior"
				},
				new ReportTypes
				{
					Id = Guid.Parse("59eff953-9268-4488-9f2a-0ce3a5b80ac3"),
					Name = "Scam or Fraud"
				},
				new ReportTypes
				{
					Id = Guid.Parse("78e8165a-c263-4790-b0f4-21d2398c3d82"),
					Name = "Performance Issues"
				},
				new ReportTypes
				{
					Id = Guid.Parse("baf14634-874b-461b-b44d-3c5d261fbdc8"),
					Name = "Other"
				},
				new ReportTypes
				{
					Id = Guid.Parse("32992805-dcef-427a-afb8-239c79cb4de9"),
					Name = "Offensive Language"
				},
				new ReportTypes
				{
					Id = Guid.Parse("7fb483f2-3499-4f56-a22f-af191fac0411"),
					Name = "False Information"
				},
				new ReportTypes
				{
					Id = Guid.Parse("b348e5d5-55ea-48ed-a5fe-b3cc56c8a7b1"),
					Name = "Harassment"
				},
				new ReportTypes
				{
					Id = Guid.Parse("3f36c22a-5f0d-4f02-ab65-b47a22ae81a7"),
					Name = "Political or Religious Extremism"
				},
				new ReportTypes
				{
					Id = Guid.Parse("a8eae5df-0705-4021-835c-75c12df9b2f2"),
					Name = "Off-topic"
				}
			);
		}
	}
}
