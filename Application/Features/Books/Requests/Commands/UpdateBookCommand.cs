using MediatR;
using Application.Responses;
using Application.DTOs.Book;

namespace Application.Features.Movies.Requests.Commands;

public class UpdateBookCommand : IRequest<BaseCommandResponse>
{
    public UpdateBookDto BookDto { get; set; }
}

