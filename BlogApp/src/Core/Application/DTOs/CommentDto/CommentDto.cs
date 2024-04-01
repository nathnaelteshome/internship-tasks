using Application.DTOs.Common;

namespace Application.DTOs.CommentDto;

public class CommentDto : BaseDto
{

    public int BlogId { get; set; }
    public int UserId { get; set; }
    public string? Content { get; set; }

}