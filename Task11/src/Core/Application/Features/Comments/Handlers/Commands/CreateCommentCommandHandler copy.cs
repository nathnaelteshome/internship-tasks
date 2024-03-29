using Application.DTOs.CommentDto;
using Application.Features.Comments.Requests.Commands;
using Application.Features.Comments.Requests.Queries;
using Application.Persistance.Contracts;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Comments.Handlers.Commands;

public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, int>
{
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;
    public CreateCommentCommandHandler(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;

    }
    public async Task<int> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
       var comment = _mapper.Map<Comment>(request.CommentDto);
        comment = await _commentRepository.UpdateAsync(comment);
        return comment.Id;
    }
}