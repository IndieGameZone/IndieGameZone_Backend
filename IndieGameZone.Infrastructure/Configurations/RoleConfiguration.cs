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
			builder.HasData(
				new Roles
				{
					Id = Guid.Parse("6f7b3f0c-3f54-4fb8-a215-33cd496c3be7"),
					Name = RoleEnum.Admin.ToString(),
					NormalizedName = RoleEnum.Admin.ToString().ToUpper()
				},
				new Roles
				{
					Id = Guid.NewGuid(),
					Name = RoleEnum.Developer.ToString(),
					NormalizedName = RoleEnum.Developer.ToString().ToUpper()
				},
				new Roles
				{
					Id = Guid.NewGuid(),
					Name = RoleEnum.Player.ToString(),
					NormalizedName = RoleEnum.Player.ToString().ToUpper()
				},
				new Roles
				{
					Id = Guid.NewGuid(),
					Name = RoleEnum.Moderator.ToString(),
					NormalizedName = RoleEnum.Moderator.ToString().ToUpper()
				}
			);
		}
	}
}
