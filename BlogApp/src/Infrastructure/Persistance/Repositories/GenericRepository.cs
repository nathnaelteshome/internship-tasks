using Application.Persistance.Contracts;

namespace Persistance.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly BlogDbContext _context;
    public GenericRepository(BlogDbContext context)
    {
        _context = context;
    }

    public Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
