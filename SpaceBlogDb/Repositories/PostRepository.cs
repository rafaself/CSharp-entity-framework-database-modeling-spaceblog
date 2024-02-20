using Microsoft.EntityFrameworkCore;
using SpaceBlogDb.Models;
using System.Reflection;

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

    public override Task<Post> GetByIdAsync(int id)
    {
        return _dbContext.Set<Post>()
            .AsNoTracking()
            .Where(post => post.Id == id)
            .Include(post => post.User)
            .FirstAsync();
    }

    public async Task UpdatePostAsync(int id, string title, string description)
    {
        var post = await _dbContext.Set<Post>()
            .Where(post => post.Id == id)
            .FirstAsync();

        post.Title = title;
        post.Description = description;
    }

}