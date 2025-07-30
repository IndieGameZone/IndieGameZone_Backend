using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class PostImageConfiguration : IEntityTypeConfiguration<PostImages>
	{
		public void Configure(EntityTypeBuilder<PostImages> builder)
		{
			builder.HasKey(pi => pi.Id);
			builder.Property(pi => pi.Image);
		}
	}
}
