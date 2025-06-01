using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class CommercialPackageConfiguration : IEntityTypeConfiguration<CommercialPackages>
	{
		public void Configure(EntityTypeBuilder<CommercialPackages> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Name).HasMaxLength(100);
			builder.Property(c => c.Description);
			builder.Property(c => c.Duration);
			builder.Property(c => c.Price);

			builder.HasMany(c => c.CommercialRegistrations)
				.WithOne(c => c.CommercialPackage)
				.HasForeignKey(c => c.CommercialPackageId)
				.OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new CommercialPackages
                {
                    Id = Guid.Parse("856314ae-b364-4d83-94ba-f11600c88cff"),
                    Name = "Homepage Banner - Daily",
                    Description = "Displays a banner on the homepage for 1 day.",
                    Duration = 1,
                    Price = 20000
                },
                new CommercialPackages
                {
                    Id = Guid.Parse("4bfbc5f2-bef6-44ff-a5c4-baaff953f651"),
                    Name = "Homepage Banner - Weekly",
                    Description = "Displays a banner on the homepage for 7 days.",
                    Duration = 7,
                    Price = 80000
                },
                new CommercialPackages
                {
                    Id = Guid.Parse("8f451273-fe64-4c67-80e9-84ee20733ddd"),
                    Name = "Homepage Banner - Monthly",
                    Description = "Displays a banner on the homepage for 30 days.",
                    Duration = 30,
                    Price = 310000
                },
                new CommercialPackages
                {
                    Id = Guid.Parse("854bb0e5-ecf6-4bc8-a5f7-1d9e27d27e73"),
                    Name = "Category Banner - Daily",
                    Description = "Displays a banner on a category page for 1 day.",
                    Duration = 1,
                    Price = 10000
                },
                new CommercialPackages
                {
                    Id = Guid.Parse("0efbfb71-599d-4233-a598-1595615810e1"),
                    Name = "Category Banner - Weekly",
                    Description = "Displays a banner on a category page for 7 days.",
                    Duration = 7,
                    Price = 60000
                },
                new CommercialPackages
                {
                    Id = Guid.Parse("a9758e65-b0d6-4dd1-8272-fe1f2cb4794e"),
                    Name = "Category Banner - Monthly",
                    Description = "Displays a banner on a category page for 30 days.",
                    Duration = 30,
                    Price = 230000
                }
            );
        }
    }
}
