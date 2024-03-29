using Application.DTOs.Common;

namespace Application.DTOs.BlogDto;

public class CreateBlogDto : BaseDto
{
    public string? Title { get; set; }
    public string? Content { get; set; }
}