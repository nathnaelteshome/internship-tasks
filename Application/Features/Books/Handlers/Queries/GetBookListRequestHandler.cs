using AutoMapper;

using MediatR;

using Application.Contracts.Persistence;
using Application.DTOs.Book;
using Application.Features.Books.Requests.Queries;


public class GetBookListRequestHandler : IRequestHandler<GetBookListRequest, List<BookDto>>
{
    private readonly IBookRepository _BookRepository;
    private readonly IMapper _mapper;

    public GetBookListRequestHandler(IBookRepository BookRepository,
            IMapper mapper)
    {
        _BookRepository = BookRepository;
        _mapper = mapper;
    }

    public async Task<List<BookDto>> Handle(GetBookListRequest request, CancellationToken cancellationToken)
    {
        var BookDTOs = new List<BookDto>();

        var Books = await _BookRepository.GetAll();
        BookDTOs = _mapper.Map<List<BookDto>>(Books.ToList());
        return BookDTOs;
    }
}

