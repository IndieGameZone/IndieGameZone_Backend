using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Persistence
{
	public class RepositoryContext : DbContext
	{
		public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
