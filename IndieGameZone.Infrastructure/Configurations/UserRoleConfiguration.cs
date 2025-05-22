using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
		{
			builder.HasData(
				new IdentityUserRole<Guid>
				{
					RoleId = Guid.Parse("6f7b3f0c-3f54-4fb8-a215-33cd496c3be7"),
					UserId = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8")
				},
				new IdentityUserRole<Guid>
				{
					RoleId = Guid.Parse("7211a346-6e23-431c-a6bd-2f02aa5de68a"),
					UserId = Guid.Parse("3fe77296-fdb3-4d71-8b99-ef8380c32037")
				},
				new IdentityUserRole<Guid>
				{
					RoleId = Guid.Parse("b86a5b00-0393-4524-9f56-fa7ca800e79c"),
					UserId = Guid.Parse("293191b7-f7b2-4f28-8857-5afa96866a2f")
				},
				new IdentityUserRole<Guid>
				{
					RoleId = Guid.Parse("51999f00-0f63-4236-8c81-94c43fcf7586"),
					UserId = Guid.Parse("23879117-e09e-40f1-b78f-1493d81baf49")
				}
			);
		}
	}
}
