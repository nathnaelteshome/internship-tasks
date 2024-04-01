using Domain;
using Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Persistance;

public class BlogDbContext : DbContext
{
    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogDbContext).Assembly);
        // modelBuilder.Entity<Blog>().HasMany(b => b.Comments).WithOne(c => c.BlogId).OnDelete(DeleteBehavior.Cascade);
        // modelBuilder.Entity<Blog>().HasMany(b => b.Like).WithOne(l => l.Blog).OnDelete(DeleteBehavior.Cascade);
    }

    public override Task <int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries().Where(e => e.Entity is BaseDomainEntity);
        foreach (var entityEntry in entries)
        {
            ((BaseDomainEntity)entityEntry.Entity).UpdatedAt = DateTime.Now;

            if(entityEntry.State == EntityState.Added)
            {
                ((BaseDomainEntity)entityEntry.Entity).CreatedAt = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }



    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Like> Likes { get; set; }

}