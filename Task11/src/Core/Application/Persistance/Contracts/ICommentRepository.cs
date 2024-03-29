using Domain;

namespace Application.Persistance.Contracts
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        Task<List<Comment>> GetpostComments(int postId);
    }
} 