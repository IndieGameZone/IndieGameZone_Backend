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
			builder.Property(x => x.Key).HasMaxLength(50);
			builder.HasIndex(x => x.Key);
			builder.Property(x => x.IsUsed);
			builder.Property(x => x.CreatedAt);

			builder.HasOne(x => x.GamePlatform)
				.WithMany(x => x.ActivationKeys)
				.HasForeignKey(x => x.GamePlatformId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
