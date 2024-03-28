using Application.DTOs.CommentDto;
using Application.Features.Comments.Requests.Queries;
using Application.Persistance.Contracts;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Comments.Handlers.Queries;

public class GetCommentPostListRequestHandler : IRequestHandler<GetPostCommentListRequest, List<CommentDto>>
{
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;
    public GetCommentPostListRequestHandler(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;

    }
    public async Task<List<CommentDto>> Handle(GetPostCommentListRequest request, CancellationToken cancellationToken)
    {
        var comments = new List<Comment>();
        var commentDTOs = new List<CommentDto>();
        
        comments = await _commentRepository.GetpostComments(request.PostId);
        commentDTOs = _mapper.Map<List<CommentDto>>(comments);
        return commentDTOs;
    }
}