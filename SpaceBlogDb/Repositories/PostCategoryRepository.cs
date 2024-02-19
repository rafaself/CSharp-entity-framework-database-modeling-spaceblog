using Microsoft.EntityFrameworkCore;
using SpaceBlogDb.Models;
using SpaceBlogDb.UseCases.PostCategory;

namespace SpaceBlogDb.Repositories;

public class PostCategoryRepository : BaseRepository<PostsCategory>
{

    CustomDbContext _dbContext;

    public PostCategoryRepository(CustomDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task UpdatePostCategory(int id, string title)
    {
        var postCategory = await _dbContext.Set<PostsCategory>()
            .Where(postCategory => postCategory.Id == id)
            .FirstAsync();

        postCategory.Title = title;

        await _dbContext.SaveChangesAsync();

    }

}
