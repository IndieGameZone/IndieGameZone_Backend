using System.Linq.Expressions;

namespace IndieGameZone.Domain.IRepositories
{
	public interface RepositoryBase<T>
	{
		IQueryable<T> FindAll(bool trackChanges);
		IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
		void Create(T entity);
		void Update(T entity);
		void Delete(T entity);
		void DeleteRange(IEnumerable<T> entities);
		void CreateRange(IEnumerable<T> entities);
	}
}
