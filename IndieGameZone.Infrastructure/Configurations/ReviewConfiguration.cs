using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class ReviewConfiguration : IEntityTypeConfiguration<Reviews>
	{
		public void Configure(EntityTypeBuilder<Reviews> builder)
		{
			builder.HasKey(r => r.Id);
			builder.Property(r => r.Rating);
			builder.Property(r => r.Comment);
			builder.Property(r => r.CreatedAt);

			builder.HasOne(r => r.User)
				.WithMany(u => u.Reviews)
				.HasForeignKey(r => r.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(r => r.Game)
				.WithMany(g => g.Reviews)
				.HasForeignKey(r => r.GameId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
