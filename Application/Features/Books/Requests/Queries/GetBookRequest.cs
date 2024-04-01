using MediatR;
using Application.Responses;
using Application.DTOs.Book;

namespace Application.Features.Movies.Requests.Queries;

public class GetBookRequest : IRequest<BookDto>
{
    public int Id { get; set; }
}

