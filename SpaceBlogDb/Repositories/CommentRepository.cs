using Microsoft.EntityFrameworkCore;
using SpaceBlogDb.Models;

namespace SpaceBlogDb.Repositories;

public class CommentRepository : BaseRepository<Comment>
{
    public CommentRepository(CustomDbContext dbContext) : base(dbContext)
    {

    }

    public async Task UpdateCommentAsync(int id, string text)
    {
        var comment = await _dbContext.Set<Comment>().Where(comment => comment.Id == id).FirstAsync();

        comment.Text = text;
    }

}

