using Application.DTOs.CommentDto;
using Application.Features.Likes.Requests.Commands;
using Application.Features.Likes.Requests.Queries;
using Application.Persistance.Contracts;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.likes.Handlers.Queries;

public class UpdateLikeCommandHandler : IRequestHandler<UpdateLikeCommand, Unit>
{
    private readonly ILikeRepository _likeRepository;
    private readonly IMapper _mapper;
    public UpdateLikeCommandHandler(ILikeRepository commentRepository, IMapper mapper)
    {
        _likeRepository = commentRepository;
        _mapper = mapper;

    }
    public async Task<Unit> Handle(UpdateLikeCommand request, CancellationToken cancellationToken)
    {
        var like = await _likeRepository.GetByIdAsync(request.LikeDto.Id);
        _mapper.Map(request.LikeDto, like);
        await _likeRepository.UpdateAsync(like);
        return Unit.Value;
    }
}