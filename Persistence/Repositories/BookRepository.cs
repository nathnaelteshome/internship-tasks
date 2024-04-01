using Application.Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;

public class BookRepository : GenericRepository<Book>, IBookRepository
{
    private readonly BookDbContext _dbContext;

    public BookRepository(BookDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}

