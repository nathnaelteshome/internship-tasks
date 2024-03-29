using Application.DTOs.CommentDto;
using Application.Features.Comments.Requests.Queries;
using Application.Persistance.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.Comments.Handlers.Queries;

public class GetCommentRequestHandler :  IRequestHandler<GetCommentRequest, CommentDto>
{
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;
    public GetCommentRequestHandler(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;

    }
    public async Task<CommentDto> Handle(GetCommentRequest request, CancellationToken cancellationToken)
    {
         var comment = await _commentRepository.GetByIdAsync(request.Id);
        
        return _mapper.Map<CommentDto>(comment);
    }
}