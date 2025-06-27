using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal abstract class RepositoryBase<T> : Domain.IRepositories.RepositoryBase<T> where T : class
	{
		protected AppDbContext AppDbContext;
		public RepositoryBase(AppDbContext appDbContext)
				=> AppDbContext = appDbContext;

		public IQueryable<T> FindAll(bool trackChanges) =>
			!trackChanges ?
			  AppDbContext.Set<T>()
				.AsNoTracking() :
			  AppDbContext.Set<T>();
		public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
		bool trackChanges) =>
			!trackChanges ?
			  AppDbContext.Set<T>()
				.Where(expression)
				.AsNoTracking() :
			  AppDbContext.Set<T>()
				.Where(expression);

		public void Create(T entity) => AppDbContext.Set<T>().Add(entity);
		public void Update(T entity) => AppDbContext.Set<T>().Update(entity);
		public void Delete(T entity) => AppDbContext.Set<T>().Remove(entity);

		public void DeleteRange(IEnumerable<T> entities) => AppDbContext.Set<T>().RemoveRange(entities);

		public void CreateRange(IEnumerable<T> entities) => AppDbContext.Set<T>().AddRange(entities);
	}
}
