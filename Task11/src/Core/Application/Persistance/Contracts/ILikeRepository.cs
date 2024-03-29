using Domain;

namespace Application.Persistance.Contracts
{
    public interface ILikeRepository : IGenericRepository<Like>
    {
        Task<List<Comment>> GetPostLikes(int postId);
    }
}