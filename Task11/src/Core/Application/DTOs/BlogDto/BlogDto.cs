using Application.DTOs.Common;
using Domain;

namespace Application.DTOs.BlogDto;

public class Blog : BaseDto
{
    public string? Title { get; set; }
    public int UserId { get; set; }
    public string? Content { get; set; }
    public List<Comment>? Comments { get; set; }
    public List<Like>? Like {get; set;}
}