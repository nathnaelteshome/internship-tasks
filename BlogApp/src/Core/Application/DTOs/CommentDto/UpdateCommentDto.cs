using Application.DTOs.Common;

namespace Application.DTOs.CommentDto;

public class UpdateCommentDto : BaseDto
{
    public string? Content { get; set; }
}