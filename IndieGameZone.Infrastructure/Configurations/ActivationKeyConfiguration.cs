using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class ActivationKeyConfiguration : IEntityTypeConfiguration<ActivationKeys>
	{
		public void Configure(EntityTypeBuilder<ActivationKeys> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Key);
			builder.HasIndex(x => x.Key);
			builder.Property(x => x.IsUsed);
			builder.Property(x => x.CreatedAt);


		}
	}
}
