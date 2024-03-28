using Application.DTOs.CommentDto;
using Application.Features.Likes.Requests.Queries;
using Application.Persistance.Contracts;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.likes.Handlers.Queries;

public class GetLikePostListRequest : IRequestHandler<GetPostLikeListRequest, List<CommentDto>>
{
    private readonly ILikeRepository _likeRepository;
    private readonly IMapper _mapper;
    public GetLikePostListRequest(ILikeRepository commentRepository, IMapper mapper)
    {
        _likeRepository = commentRepository;
        _mapper = mapper;

    }
    public async Task<List<CommentDto>> Handle(GetPostLikeListRequest request, CancellationToken cancellationToken)
    {
        var likes = new List<Comment>();
        var likeDTOs = new List<CommentDto>();
        
        likes = await _likeRepository.GetPostLikes(request.PostId);
        likeDTOs = _mapper.Map<List<CommentDto>>(likes);
        return likeDTOs;
    }
}