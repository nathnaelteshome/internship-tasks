using System.ComponentModel.DataAnnotations;
using Application.DTOs.CommentDto;
using Application.Exceptions;
using Application.Features.Comments.Requests.Commands;
using Application.Features.Comments.Requests.Queries;
using Application.Persistance.Contracts;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Comments.Handlers.Commands
{
    public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommand>
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;
        public DeleteCommentCommandHandler(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;

        }
        public async Task<Unit> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = await _commentRepository.GetByIdAsync(request.Id);

            if(comment == null)
            {
                throw new NotFoundException(nameof(Comment), request.Id);
            }
            await _commentRepository.DeleteAsync(comment);
            return Unit.Value;
        }
    }
}

