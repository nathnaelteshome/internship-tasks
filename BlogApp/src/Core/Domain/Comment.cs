using Domain.Common;

namespace Domain;

public class Comment : BaseDomainEntity
{
    public int BlogId {get; set;}
    public int UserId { get; set; }
    public string? Content { get; set; }
    // public Blog? Bl og { get; set; } 
}