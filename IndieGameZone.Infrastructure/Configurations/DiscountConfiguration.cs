using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class DiscountConfiguration : IEntityTypeConfiguration<Discounts>
	{
		public void Configure(EntityTypeBuilder<Discounts> builder)
		{
			builder.HasKey(d => d.Id);
			builder.Property(d => d.Percentage);
			builder.Property(d => d.StartDate);
			builder.Property(d => d.EndDate);

			builder.HasOne(d => d.Game)
				.WithMany(g => g.Discounts)
				.HasForeignKey(d => d.GameId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				new Discounts
				{
					Id = Guid.Parse("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
					Percentage = 10.0,
					StartDate = DateOnly.FromDateTime(DateTime.Now),
					EndDate = DateOnly.FromDateTime(DateTime.Now).AddDays(10),
					GameId = Guid.Parse("65745560-c7e9-48c3-bc36-8c88d66458c7")
				}
			);
		}
	}
}
