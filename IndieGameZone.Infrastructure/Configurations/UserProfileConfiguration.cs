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

			builder.HasData(
				new UserProfiles
				{
					UserId = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"),
					Fullname = "Admin",
					Avatar = "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=",
					Birthday = DateOnly.ParseExact("2002-01-23", "yyyy-MM-dd"),
				},
				new UserProfiles
				{
					UserId = Guid.Parse("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
					Fullname = "Moderator",
					Avatar = "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=",
					Birthday = DateOnly.ParseExact("2002-01-23", "yyyy-MM-dd"),
				}
			);
		}
	}
}
