using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class PostCommentConfiguration : IEntityTypeConfiguration<PostComments>
	{
		public void Configure(EntityTypeBuilder<PostComments> builder)
		{
			builder.HasKey(p => p.Id);
			builder.Property(b => b.Content);
			builder.Property(b => b.CreatedAt);
			builder.Property(b => b.UpdatedAt);
			builder.Property(b => b.IsActive);

			builder.HasOne(b => b.User)
				.WithMany(b => b.PostComments)
				.HasForeignKey(b => b.UserId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
