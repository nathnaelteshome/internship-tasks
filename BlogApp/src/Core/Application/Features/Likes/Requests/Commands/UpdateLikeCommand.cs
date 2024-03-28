using Application.DTOs.CommentDto;
using Application.DTOs.LikeDto;
using MediatR;

namespace Application.Features.Likes.Requests.Commands;

public class UpdateLikeCommand : IRequest<Unit>
{
    public UpdateLikeDto LikeDto { get; set; }
}