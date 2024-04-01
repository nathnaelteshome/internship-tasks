using System.Linq.Expressions;

namespace Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<T> Get(int id);
    Task<IReadOnlyList<T>> GetAll();
    Task<T> Add(T entity);
    Task<bool> Exists(int id);
    Task Update(T entity);
    Task Delete(T entity);
    Task<IReadOnlyList<T>> Search(Expression<Func<T, bool>> criteria);
}

