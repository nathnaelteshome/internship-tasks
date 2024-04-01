using Domain.Entities;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Persistence;

public class BookDbContext : DbContext
{
    public BookDbContext(DbContextOptions<BookDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookDbContext).Assembly);
    }

    public DbSet<Book> Books { get; set; }

    public virtual async Task<int> SaveChangesAsync(string username = "SYSTEM")
    {
      
        var result = await base.SaveChangesAsync();

        return result;
    }
}

