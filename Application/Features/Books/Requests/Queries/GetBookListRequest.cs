using MediatR;
using Application.DTOs.Book;

namespace Application.Features.Books.Requests.Queries;

public class GetBookListRequest : IRequest<List<BookDto>>
{
}

