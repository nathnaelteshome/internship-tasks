using Application.DTOs.CommentDto;
using MediatR;

namespace Application.Features.Comments.Requests.Queries;

public class GetCommentRequest : IRequest<CommentDto>
{
    public int Id { get; set; }
}