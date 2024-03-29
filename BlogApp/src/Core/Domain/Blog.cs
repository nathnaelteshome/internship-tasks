using Domain.Common;

namespace Domain;

public class Blog : BaseDomainEntity
{
    public string? Title { get; set; }
    public int UserId { get; set; }
    public string? Content { get; set; }
    public List<Comment>? Comments { get; set; }
    public List<Like>? Like {get; set;}
}