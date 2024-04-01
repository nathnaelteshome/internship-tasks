using Application.DTOs.Common;

namespace Application.DTOs.CommentDto;

public class CreateCommentDto : BaseDto
{
    public string? Content { get; set; }
    public int UserId { get; set; }
    public int BlogId { get; set; }
}