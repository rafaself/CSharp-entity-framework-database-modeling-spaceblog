﻿using Microsoft.EntityFrameworkCore;
using SpaceBlogDb.Models;

namespace SpaceBlogDb.Repositories;

public class PostRepository(CustomDbContext dbContext) : BaseRepository<Post>(dbContext)
{
    public override Task<List<Post>> ListAllAsync()
    {
        return _dbContext.Set<Post>()
            .AsNoTracking()
            .OrderBy(post => post.Id)
            .Include(post => post.User)
            .ToListAsync();
    }

}