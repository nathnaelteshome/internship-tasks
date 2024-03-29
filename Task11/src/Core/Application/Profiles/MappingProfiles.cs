using Application.DTOs.BlogDto;
using Application.DTOs.CommentDto;
using AutoMapper;
using Domain;

namespace Application.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Blog, CreateBlogDto>().ReverseMap();
        CreateMap<Blog, UpdateBlogDto>().ReverseMap();
        CreateMap<Blog, ListBlogDto>().ReverseMap();
        CreateMap<Comment, ListCommentDto>().ReverseMap();
        CreateMap<Comment, CreateCommentDto>().ReverseMap();
        CreateMap<Comment, UpdateCommentDto>().ReverseMap();
    }

}