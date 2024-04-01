using MediatR;
using Application.Responses;
using Application.DTOs.Book;

namespace Application.Features.Movies.Requests.Commands;

public class CreateBookCommand : IRequest<BaseCommandResponse>
{
    public CreateBookDto BookDto { get; set; }
}

