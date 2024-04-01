﻿using AutoMapper;
using MediatR;
using Application.Features.Movies.Requests.Commands;
using Application.Responses;
using Application.Contracts.Persistence;

namespace Application.Features.Books.Handlers.Commands;

public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand,BaseCommandResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DeleteBookCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<BaseCommandResponse> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
    {
        var response = new BaseCommandResponse();
        var Book = await _unitOfWork.BookRepository.Get(request.Id);
        response.Id = request.Id; 
        if (Book == null){
            response.Success = false;
            response.Message = "Book Update Failed";
            response.Errors = new List<string>{
                "Book not found"
            };
        }else{
            await _unitOfWork.BookRepository.Delete(Book);
            await _unitOfWork.Save();
            response.Success = true;
            response.Message = "Book Deleted";   
        }   
        return response;
    }
}

