using Application.DTOs.Common;

namespace Application.DTOs.BlogDto;

public class ListBlogDto : BaseDto
{
    public string? Title { get; set; }
    public int UserId { get; set; }
    public string? Content { get; set; }
}