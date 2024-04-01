using Application.DTOs.CommentDto;
using MediatR;

namespace Application.Features.Comments.Requests.Commands;

public class CreateCommentCommand : IRequest<int>
{
    public CreateCommentDto CommentDto { get; set; }
}