using Application.Features.Comments.Requests.Commands;
using Application.Persistance.Contracts;
using AutoMapper;
using MediatR;
using Application.DTOs.CommentDto.Validators;
using Application.Exceptions;

namespace Application.Features.Comments.Handlers.Commands
{
    public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand, Unit>
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;
        public UpdateCommentCommandHandler(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;

        }
        public async Task<Unit> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
        var validator = new UpdateCommentDtoValidator();
        var validationResult = await validator.ValidateAsync(request.CommentDto);
         if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult);
        }
        var comment = await _commentRepository.GetByIdAsync(request.CommentDto.Id);
        _mapper.Map(request.CommentDto, comment);
        await _commentRepository.UpdateAsync(comment);
        return Unit.Value;
        }
    }
}

