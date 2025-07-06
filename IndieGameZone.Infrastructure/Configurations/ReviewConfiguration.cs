using IndieGameZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndieGameZone.Infrastructure.Configurations
{
	public class ReviewConfiguration : IEntityTypeConfiguration<Reviews>
	{
		public void Configure(EntityTypeBuilder<Reviews> builder)
		{
			builder.HasKey(r => r.Id);
			builder.Property(r => r.Rating);
			builder.Property(r => r.Comment);
			builder.Property(r => r.CreatedAt);

			builder.HasOne(r => r.User)
				.WithMany(u => u.Reviews)
				.HasForeignKey(r => r.UserId)
				.OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(r => r.Game)
				.WithMany(g => g.Reviews)
				.HasForeignKey(r => r.GameId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(
				new Reviews
				{
					Id = Guid.NewGuid(),
					Rating = 5,
					Comment = "This is the best game I have ever seen",
					CreatedAt = DateTime.Now,
					UserId = Guid.Parse("23879117-e09e-40f1-b78f-1493d81baf49"),
					GameId = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8")
				},
				new Reviews
				{
					Id = Guid.NewGuid(),
					Rating = 4,
					Comment = "This game gives me a cozy vibe",
					CreatedAt = DateTime.Now,
					UserId = Guid.Parse("91b106fa-7b95-480f-a12a-0e0303454332"),
					GameId = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8")
				},
				new Reviews
				{
					Id = Guid.NewGuid(),
					Rating = 3,
					Comment = "This game is good, but it has some bugs",
					CreatedAt = DateTime.Now,
					UserId = Guid.Parse("537f05fd-120c-40b0-b2ec-639756f866ab"),
					GameId = Guid.Parse("16565861-4a29-40e7-8efa-1594a82e67e8")
				}
			);
		}
	}
}
