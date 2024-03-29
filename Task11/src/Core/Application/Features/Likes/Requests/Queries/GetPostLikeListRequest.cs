using Application.DTOs.CommentDto;
using MediatR;

namespace Application.Features.Likes.Requests.Queries;

public class GetPostLikeListRequest : IRequest<List<CommentDto>>
{
    public int PostId { get; set; }
}