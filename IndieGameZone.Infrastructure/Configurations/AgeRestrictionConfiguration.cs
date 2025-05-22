using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class AgeRestrictionConfiguration : IEntityTypeConfiguration<AgeRestrictions>
	{
		public void Configure(EntityTypeBuilder<AgeRestrictions> builder)
		{
			builder.HasKey(a => a.Id);
			builder.Property(a => a.Code).HasMaxLength(10);
			builder.Property(a => a.Description).HasMaxLength(100);

			builder.HasMany(a => a.Games)
				.WithOne(g => g.AgeRestriction)
				.HasForeignKey(g => g.AgeRestrictionId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasData(
				new AgeRestrictions
				{
					Id = Guid.Parse("c91901a1-1b27-4e42-9b6f-869c920b1b1c"),
					Code = "PEGI 3",
					Description = "Suitable for all age groups. No sounds or pictures likely to frighten young children."
				},
				new AgeRestrictions
				{
					Id = Guid.Parse("c48f1c63-f301-44e9-8766-3d4b60134b5f"),
					Code = "PEGI 7",
					Description = "May contain some frightening scenes or sounds."
				},
				new AgeRestrictions
				{
					Id = Guid.Parse("32d6d768-d670-4ef5-acaa-fcfe4c8167d3"),
					Code = "PEGI 12",
					Description = "May contain violence of a more graphic nature towards fantasy characters, or mild bad language."
				},
				new AgeRestrictions
				{
					Id = Guid.Parse("3df25298-5f31-4639-a3a0-425ae4db72ca"),
					Code = "PEGI 16",
					Description = "More realistic violence, sexual activity, use of tobacco or alcohol, and stronger language."
				},
				new AgeRestrictions
				{
					Id = Guid.Parse("92ca7f1e-94c3-4c48-a468-61d3bab8f0b9"),
					Code = "PEGI 18",
					Description = "Depictions of gross violence, sexual violence, or content that glamorizes illegal drug use."
				}
			);
		}
	}
}
