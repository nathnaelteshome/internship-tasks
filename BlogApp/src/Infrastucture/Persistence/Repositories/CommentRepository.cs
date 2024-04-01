using Application.Contracts.Persistence;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.Data;

namespace Persistence.Repositories;

public class CommentRepository : GenericRepository<Comment>, ICommentRepository
{
    private readonly BlogContext _dbContext;

    public Comment
Repository(BlogContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}

