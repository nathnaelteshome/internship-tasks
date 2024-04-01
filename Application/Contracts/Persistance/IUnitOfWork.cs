namespace Application.Contracts.Persistence;

public interface IUnitOfWork : IDisposable
{
    IBookRepository BookRepository { get; }
    Task Save();
}
