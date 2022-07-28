using System.Linq.Expressions;

namespace ShopsRUsRetailStore.Core.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {

        Task AddAsync(TEntity entity);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
        Task<IList<TDto>> GetAllList<TDto>(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties);
        Task<TDto> GetAsync<TDto>(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
