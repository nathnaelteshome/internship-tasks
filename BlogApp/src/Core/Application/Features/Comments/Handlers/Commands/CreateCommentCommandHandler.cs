using Application.DTOs.CommentDto.Validators;
using Application.Exceptions;
using Application.Features.Comments.Requests.Commands;
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
        var validator = new CreateCommentDtoValidator();
        var validationResult = await validator.ValidateAsync(request.CommentDto);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult);
        }
       var comment = _mapper.Map<Comment>(request.CommentDto);
        comment = await _commentRepository.AddAsync(comment);
        return comment.Id;
    }
}