using Application.DTOs.Common;
using Domain;

namespace Application.DTOs.BlogDto;

public class BlogDto : BaseDto
{
    public string? Title { get; set; }
    public int UserId { get; set; }
    public string? Content { get; set; }
}