using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class RoleConfiguration : IEntityTypeConfiguration<Roles>
	{
		public void Configure(EntityTypeBuilder<Roles> builder)
		{
			builder.ToTable("Roles");
			builder.HasData(
				new Roles
				{
					Id = Guid.Parse("6f7b3f0c-3f54-4fb8-a215-33cd496c3be7"),
					Name = RoleEnum.Admin.ToString(),
					NormalizedName = RoleEnum.Admin.ToString().ToUpper()
				},
				new Roles
				{
					Id = Guid.Parse("7211a346-6e23-431c-a6bd-2f02aa5de68a"),
					Name = RoleEnum.Moderator.ToString(),
					NormalizedName = RoleEnum.Moderator.ToString().ToUpper()
				},
				new Roles
				{
					Id = Guid.Parse("b86a5b00-0393-4524-9f56-fa7ca800e79c"),
					Name = RoleEnum.Developer.ToString(),
					NormalizedName = RoleEnum.Developer.ToString().ToUpper()
				},
				new Roles
				{
					Id = Guid.Parse("51999f00-0f63-4236-8c81-94c43fcf7586"),
					Name = RoleEnum.Player.ToString(),
					NormalizedName = RoleEnum.Player.ToString().ToUpper()
				}
			);
		}
	}
}
