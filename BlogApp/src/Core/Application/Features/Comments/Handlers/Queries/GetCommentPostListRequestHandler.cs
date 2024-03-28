using Application.DTOs.CommentDto;
using Application.Features.Comments.Requests.Queries;
using Application.Persistance.Contracts;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Comments.Handlers.Queries;

public class GetCommentPostListRequestHandler : IRequestHandler<GetPostCommentListRequest, List<ListCommentDto>>
{
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;
    public GetCommentPostListRequestHandler(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;

    }
    public async Task<List<ListCommentDto>> Handle(GetPostCommentListRequest request, CancellationToken cancellationToken)
    {
        var comments = new List<Comment>();
        var commentDTOs = new List<ListCommentDto>();
        
        comments = await _commentRepository.GetpostComments(request.PostId);
        commentDTOs = _mapper.Map<List<ListCommentDto>>(comments);
        return commentDTOs;
    }
}