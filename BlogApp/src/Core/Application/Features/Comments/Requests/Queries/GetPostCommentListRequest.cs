using Application.DTOs.CommentDto;
using MediatR;

namespace Application.Features.Comments.Requests.Queries;

public class GetPostCommentListRequest : IRequest<List<ListCommentDto>>
{
    public int PostId { get; set; }
}