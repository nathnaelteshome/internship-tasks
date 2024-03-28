namespace Domain;

public class Like
{
    public int LikeId { get; set; }
    public string? UserId { get; set; }
    public int BlogId { get; set; }
    public DateTime CreatedAt { get; set; }
}