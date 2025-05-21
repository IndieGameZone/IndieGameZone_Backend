using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfiles>
	{
		public void Configure(EntityTypeBuilder<UserProfiles> builder)
		{
			builder.HasKey(u => u.UserId);
			builder.Property(u => u.Fullname).HasMaxLength(150);
			builder.Property(u => u.Avatar);
			builder.Property(u => u.Bio);
			builder.Property(u => u.Birthday);
			builder.Property(u => u.FacebookLink);
			builder.Property(u => u.BankName);
			builder.Property(u => u.BankAccount);

			builder.HasOne(u => u.User)
				.WithOne(u => u.UserProfile)
				.HasForeignKey<UserProfiles>(u => u.UserId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
