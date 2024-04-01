using AutoMapper;
using MediatR;

using Application.Contracts.Persistence;
using Application.Responses;
using Application.Features.Movies.Requests.Commands;
using Application.DTOs.Book.Validators;
using Domain.Entities;

namespace Application.Features.Books.Handlers.Commands;

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, BaseCommandResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateBookCommandHandler(
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<BaseCommandResponse> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateBookDtoValidator();
        var validationResult = await validator.ValidateAsync(request.BookDto);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Book creation Failed";
            response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
        }
        else
        {

            var Book = _mapper.Map<Book>(request.BookDto);

            Book = await _unitOfWork.BookRepository.Add(Book);
            await _unitOfWork.Save();
            
            response.Success = true;
            response.Message = "Creation Successful";
            response.Id = Book.Id;
        }
        return response;
    }
}

