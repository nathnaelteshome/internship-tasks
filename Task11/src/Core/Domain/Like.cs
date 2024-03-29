using Domain.Common;

namespace Domain;

public class Like : BaseDomainEntity
{
    public string? UserId { get; set; }
    public int BlogId { get; set; }
}