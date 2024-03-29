using Application.DTOs.Common;

namespace Application.DTOs.CommentDto;

public class UpdateCommentDto : BaseDto
{
    public string? Content { get; set; }
    public int UserId { get; set; }
    public int PostId { get; set; }
}