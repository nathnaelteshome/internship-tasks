namespace Application.Persistance.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<bool> ExistsAsync(int id);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
    }
}