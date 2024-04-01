using AutoMapper;

using MediatR;
using System.Threading;
using System.Threading.Tasks;

using Application.Contracts.Persistence;
using Application.Responses;
using Application.Features.Movies.Requests.Queries;
using Application.DTOs.Book;

namespace Application.Features.Books.Handlers.Queries;

public class GetBookDetailRequestHandler : IRequestHandler<GetBookRequest, BookDto>
{
    private readonly IBookRepository _BookRepository;
    private readonly IMapper _mapper;

    public GetBookDetailRequestHandler(IBookRepository BookRepository, IMapper mapper)
    {
        _BookRepository = BookRepository;
        _mapper = mapper;
    }
    public async Task<BookDto> Handle(GetBookRequest request, CancellationToken cancellationToken)
    {
        var Book = await _BookRepository.Get(request.Id);
        return _mapper.Map<BookDto>(Book);
    }
}

