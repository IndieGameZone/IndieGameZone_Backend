using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class ReportReasonConfiguration : IEntityTypeConfiguration<ReportReasons>
	{
		public void Configure(EntityTypeBuilder<ReportReasons> builder)
		{
			builder.HasKey(rt => rt.Id);
			builder.Property(rt => rt.Name);
			builder.Property(t => t.Type).HasConversion<string>().HasMaxLength(10);

			builder.HasMany(rt => rt.Reports)
				.WithOne(r => r.ReportReason)
				.HasForeignKey(r => r.ReportReasonId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				new ReportReasons
				{
					Id = Guid.Parse("8b92d32e-0aa0-4f88-bc43-0e04c4121e0e"),
					Name = "Copyright Infringement",
					Type = ReportReasonTypeEnum.Game
				},
				new ReportReasons
				{
					Id = Guid.Parse("1c0d2f16-1f4a-4c5e-9c26-2e86e0cfa28f"),
					Name = "Malicious Behavior",
					Type = ReportReasonTypeEnum.Game
				},
				new ReportReasons
				{
					Id = Guid.Parse("59eff953-9268-4488-9f2a-0ce3a5b80ac3"),
					Name = "Scam or Fraud",
					Type = ReportReasonTypeEnum.Game
				},
				new ReportReasons
				{
					Id = Guid.Parse("78e8165a-c263-4790-b0f4-21d2398c3d82"),
					Name = "Performance Issues",
					Type = ReportReasonTypeEnum.Game
				},
				new ReportReasons
				{
					Id = Guid.Parse("77cf1c6b-bc98-4c98-8a7e-27f2c4b45377"),
					Name = "Inappropriate Content",
					Type = ReportReasonTypeEnum.Post
				},
				new ReportReasons
				{
					Id = Guid.Parse("32992805-dcef-427a-afb8-239c79cb4de9"),
					Name = "Offensive Language",
					Type = ReportReasonTypeEnum.Post
				},
				new ReportReasons
				{
					Id = Guid.Parse("7fb483f2-3499-4f56-a22f-af191fac0411"),
					Name = "False Information",
					Type = ReportReasonTypeEnum.Post
				},
				new ReportReasons
				{
					Id = Guid.Parse("b348e5d5-55ea-48ed-a5fe-b3cc56c8a7b1"),
					Name = "Harassment",
					Type = ReportReasonTypeEnum.Post
				},
				new ReportReasons
				{
					Id = Guid.Parse("3f36c22a-5f0d-4f02-ab65-b47a22ae81a7"),
					Name = "Political or Religious Extremism",
					Type = ReportReasonTypeEnum.Post
				},
				new ReportReasons
				{
					Id = Guid.Parse("a8eae5df-0705-4021-835c-75c12df9b2f2"),
					Name = "Off-topic",
					Type = ReportReasonTypeEnum.Post
				},
				new ReportReasons
				{
					Id = Guid.Parse("cf9fce91-e2d6-46b1-baa3-c0a11eb96c30"),
					Name = "Inappropriate Content",
					Type = ReportReasonTypeEnum.Comment
				},
				new ReportReasons
				{
					Id = Guid.Parse("4f1491bf-15be-4e7a-83b4-c20a8017bf59"),
					Name = "Offensive Language",
					Type = ReportReasonTypeEnum.Comment
				},
				new ReportReasons
				{
					Id = Guid.Parse("b7ae8b62-4cc1-4e45-9515-2c9a1a6e71b1"),
					Name = "False Information",
					Type = ReportReasonTypeEnum.Comment
				},
				new ReportReasons
				{
					Id = Guid.Parse("d2ebbb20-5e8c-4d8e-aace-d499e04862a2"),
					Name = "Harassment",
					Type = ReportReasonTypeEnum.Comment
				},
				new ReportReasons
				{
					Id = Guid.Parse("93d1432e-880f-4b87-b2fc-20e7d01b17b7"),
					Name = "Political or Religious Extremism",
					Type = ReportReasonTypeEnum.Comment
				},
				new ReportReasons
				{
					Id = Guid.Parse("e85da0be-4fe1-42b1-8260-97a13e82ae5c"),
					Name = "Off-topic",
					Type = ReportReasonTypeEnum.Comment
				}
			);
		}
	}
}
