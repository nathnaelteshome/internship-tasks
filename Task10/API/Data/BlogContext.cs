using Microsoft.EntityFrameworkCore;
using Task9.Models;

namespace Task9.Data;

public class BlogContext : DbContext
{
  public BlogContext(DbContextOptions<BlogContext> options) : base(options)
  {
  }


  public DbSet<Post> Posts { get; set; }
  public DbSet<Comment> Comments { get; set; }
}


