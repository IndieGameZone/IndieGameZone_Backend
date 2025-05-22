using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class LanguageConfiguration : IEntityTypeConfiguration<Languages>
	{
		public void Configure(EntityTypeBuilder<Languages> builder)
		{
			builder.HasKey(l => l.Id);
			builder.Property(l => l.Name).HasMaxLength(100);

			builder.HasMany(l => l.GameLanguages)
				.WithOne(l => l.Language)
				.HasForeignKey(l => l.LanguageId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasData(
				new Languages
				{
					Id = Guid.Parse("80e3581d-3836-4921-a838-b7d917b5e11f"),
					Name = "Vietnamese"
				},
				new Languages
				{
					Id = Guid.Parse("8f29f2a5-146d-44df-95ba-a972e36b7527"),
					Name = "English"
				},
				new Languages
				{
					Id = Guid.Parse("2f98f2c8-2640-4cff-a8eb-ed61d9179dcb"),
					Name = "Spanish"
				},
				new Languages
				{
					Id = Guid.Parse("ae4f3cfb-6dd6-473b-a1c6-695f9edce11e"),
					Name = "French"
				},
				new Languages
				{
					Id = Guid.Parse("73b3d9d2-ecbf-4d91-95ad-e9a48b7e54cd"),
					Name = "German"
				},
				new Languages
				{
					Id = Guid.Parse("11a64feb-23f6-41ad-a55f-a9f487d04a85"),
					Name = "Chinese"
				},
				new Languages
				{
					Id = Guid.Parse("04adfb56-cb77-4209-8fc3-a7b96b768784"),
					Name = "Japanese"
				},
				new Languages
				{
					Id = Guid.Parse("3ec80948-8c1a-46aa-9fd6-01feeb273c22"),
					Name = "Russian"
				},
				new Languages
				{
					Id = Guid.Parse("149615f6-6214-4e42-a016-1dba7d248c0f"),
					Name = "Korean"
				},
				new Languages
				{
					Id = Guid.Parse("ca29265a-4bab-4aa1-a819-9636878b50da"),
					Name = "Portuguese"
				}
			);
		}
	}
}
