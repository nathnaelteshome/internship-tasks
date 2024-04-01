using Application.DTOs.Common;

namespace Application.DTOs.CommentDto;

public class ListCommentDto : BaseDto
{
    public string? Content { get; set; }
    public int BlogId { get; set; }
}