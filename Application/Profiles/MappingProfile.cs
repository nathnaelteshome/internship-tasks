using Application.DTOs.Book;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        CreateMap<Book, BookDto>().ReverseMap();
        CreateMap<Book, CreateBookDto>().ReverseMap();
        CreateMap<Book, UpdateBookDto>().ReverseMap();
        CreateMap<Book, DeleteBookDto>().ReverseMap();
    }
}

